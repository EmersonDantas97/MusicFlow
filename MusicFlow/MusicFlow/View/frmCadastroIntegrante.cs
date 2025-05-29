using Microsoft.VisualBasic;
using MusicFlow.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicFlow.View
{
    public partial class frmCadastroIntegrante : Form
    {
        private readonly FuncoesController funcoesController;
        private readonly IntegrantesBandaController integranteBandaController;
        public frmCadastroIntegrante()
        {
            InitializeComponent();
            funcoesController = new FuncoesController();
            integranteBandaController = new IntegrantesBandaController();
        }

        #region Metodos - Abstracao
        private List<Models.Funcao> ListaDeFuncoesDoMusico()
        {
            List<Models.Funcao> funcoes = new List<Models.Funcao>();

            foreach (DataGridViewRow linha in dgvFuncoes.Rows)
            {
                if (Convert.ToBoolean(linha.Cells[0].Value) == true)
                {
                    funcoes.Add(funcoesController.GetById(Convert.ToInt32(linha.Cells[2].Value)));
                }
            }

            return funcoes;
        }
        private void CadastraNovoMusico()
        {
            Models.IntegranteBanda novoIntegrante = new Models.IntegranteBanda();

            novoIntegrante.Nome = txtNome.Text;
            novoIntegrante.DataAniversario = Convert.ToDateTime(txtDataNascimento.Text);
            novoIntegrante.Fone = txtWhats.Text;
            novoIntegrante.Funcoes = ListaDeFuncoesDoMusico();

            integranteBandaController.AdicionarIntegrante(novoIntegrante);

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
            var listaDeFuncoes = funcoesController.Get();

            dgvFuncoes.Rows.Clear();

            foreach (var funcao in listaDeFuncoes)
            {
                int indiceDaLinha = dgvFuncoes.Rows.Add();

                dgvFuncoes.Rows[indiceDaLinha].Cells[0].Value = false;
                dgvFuncoes.Rows[indiceDaLinha].Cells[1].Value = funcao.Nome;
                dgvFuncoes.Rows[indiceDaLinha].Cells[2].Value = funcao.Id;
            }
        }
        private async Task CadastraNovaFuncao()
        {
            Models.Funcao funcao = new Models.Funcao();

            funcao.Nome = Interaction.InputBox("Digite o nome da nova função", "Cadastro de função");
            funcao.Status = Models.Status.Ativo;
            funcao.DataCadastro = DateTime.Now;

            await funcoesController.AdicionarFuncao(funcao);

            MessageBox.Show("Função adicionada com SUCESSO!", "Função cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void AtualizaGridIntegrantes()
        {
            var listaDeIntegrantes = integranteBandaController.BuscarIntegrantesAtivos();

            dgvIntegrantes.Rows.Clear();

            foreach (Models.IntegranteBanda integrante in listaDeIntegrantes)
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

            CadastraNovoMusico();
            MessageBox.Show("Integrante cadastrado com SUCESSO!", "Cadastro de integrante", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PreparaNovoCadastro();
            AtualizaGridIntegrantes();

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
