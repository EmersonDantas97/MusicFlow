using Microsoft.VisualBasic;
using MusicFlow.Controller;
using MusicFlow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicFlow.View
{
    public partial class frmCadastroIntegrante : Form
    {
        private readonly FuncoesController funcoesController = new FuncoesController();
        private readonly IntegrantesBandaController integranteBandaController = new IntegrantesBandaController();
        public frmCadastroIntegrante()
        {
            InitializeComponent();
        }

        #region Metodos - Abstracao
        private List<Funcao> ListaDeFuncoesDoMusico()
        {
            List<Funcao> funcoes = new List<Funcao>();

            foreach (DataGridViewRow linha in dgvFuncoes.Rows)
            {
                if (Convert.ToBoolean(linha.Cells[0].Value) == true)
                {
                    funcoes.Add(funcoesController.BuscarFuncao(Convert.ToInt32(linha.Cells[2].Value)));
                }
            }

            return funcoes;
        }
        private void CadastraNovoMusico()
        {
            IntegranteBanda novoIntegrante = integranteBandaController.AdicionarIntegrante(new IntegranteBanda
            {
                Nome = txtNome.Text,
                DataAniversario = Convert.ToDateTime(txtDataNascimento.Text),
                Fone = txtWhats.Text,
                Funcoes = ListaDeFuncoesDoMusico()
            });

            txtCodigo.Text = novoIntegrante.Id.ToString();
        }
        private void PreparaNovoCadastro()
        {
            txtCodigo.Clear();
            txtNome.Focus();

            txtDataNascimento.Clear();
            txtNome.Clear();
            txtPesquisar.Clear();
            txtWhats.Clear();

            LimpaSelecoesGridFuncoes();
        }
        private void LimpaSelecoesGridFuncoes()
        {
            foreach (DataGridViewRow linha in dgvFuncoes.Rows)
                linha.Cells[0].Value = false;
        }
        private void AtualizaGridFuncoes()
        {
            var listaDeFuncoes = funcoesController.BuscarFuncoesAtivas();

            dgvFuncoes.Rows.Clear();

            foreach (var funcao in listaDeFuncoes)
            {
                int indiceDaLinha = dgvFuncoes.Rows.Add();

                dgvFuncoes.Rows[indiceDaLinha].Cells[0].Value = false;
                dgvFuncoes.Rows[indiceDaLinha].Cells[1].Value = funcao.Nome;
                dgvFuncoes.Rows[indiceDaLinha].Cells[2].Value = funcao.Id;
            }
        }
        private void CadastraNovaFuncao()
        {
            string nomeNovaFuncao = Interaction.InputBox("Digite o nome da nova função", "Cadastro de função");

            funcoesController.AdicionarFuncao(nomeNovaFuncao);

            MessageBox.Show("Função adicionada com SUCESSO!", "Função cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void AtualizaGridIntegrantes()
        {
            var listaDeIntegrantes = integranteBandaController.BuscarIntegrantesAtivos();

            dgvIntegrantes.Rows.Clear();

            foreach (IntegranteBanda integrante in listaDeIntegrantes)
            {
                int indiceDaLinha = dgvIntegrantes.Rows.Add();

                string nomesFuncoes = string.Join(", ", integrante.Funcoes.Select(f => f.Nome));

                dgvIntegrantes.Rows[indiceDaLinha].Cells[0].Value = integrante.Id;
                dgvIntegrantes.Rows[indiceDaLinha].Cells[1].Value = integrante.Nome;
                dgvIntegrantes.Rows[indiceDaLinha].Cells[2].Value = integrante.Fone;
                dgvIntegrantes.Rows[indiceDaLinha].Cells[3].Value = integrante.DataAniversario.ToString("d");
                dgvIntegrantes.Rows[indiceDaLinha].Cells[4].Value = integrante.DataCadastro.ToString("g");
                dgvIntegrantes.Rows[indiceDaLinha].Cells[5].Value = nomesFuncoes;
            }
        } 
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ListaDeFuncoesDoMusico().Count > 1 &&
                txtNome.TextLength > 4 &&
                txtWhats.TextLength > 10)
            {
                CadastraNovoMusico();
                MessageBox.Show("Integrante cadastrado com SUCESSO!", "Cadastro de integrante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PreparaNovoCadastro();
                AtualizaGridIntegrantes();
            }
            else
            {
                MessageBox.Show("Não é possível realizar o cadastro, pois não foi selecionada nenhuma função!", "Cadastro de integrante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCadastroIntegrante_Load(object sender, EventArgs e)
        {
            AtualizaGridFuncoes();
            AtualizaGridIntegrantes();
        }
        private void frmCadastroIntegrante_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.F1:
                    btnSalvar.PerformClick();
                    break;

                case Keys.F2:
                    btnExcluir.PerformClick();
                    break;

                case Keys.F3:
                    txtPesquisar.Focus();
                    break;

                case Keys.F4:
                    CadastraNovaFuncao();
                    AtualizaGridFuncoes();
                    break;
            }
        }
    }
}
