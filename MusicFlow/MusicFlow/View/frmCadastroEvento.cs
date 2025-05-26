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
    public partial class frmCadastroEvento : Form
    {
        private readonly IntegrantesBandaController integranteBandaController = new IntegrantesBandaController();
        private readonly EventosController eventosController = new EventosController();

        public frmCadastroEvento()
        {
            InitializeComponent();
        }

        private void atualizaGridFuncoes()
        {
            var funcoesIntegrantes = integranteBandaController.BuscarIntegrantesAtivos();

            dgvBanda.Rows.Clear();

            foreach (var integrante in funcoesIntegrantes)
            {
                foreach (var integranteFuncao in integrante.Funcoes)
                {
                    int indiceDaLinha = dgvBanda.Rows.Add();

                    dgvBanda.Rows[indiceDaLinha].Cells[0].Value = false;
                    dgvBanda.Rows[indiceDaLinha].Cells[1].Value = $"{integrante.Nome} ({integranteFuncao.Nome})";
                    dgvBanda.Rows[indiceDaLinha].Cells[2].Value = integrante.Id;
                    dgvBanda.Rows[indiceDaLinha].Cells[3].Value = integranteFuncao.Id;
                }
            }
        }

        private void frmCadastroEvento_Load(object sender, EventArgs e)
        {
            atualizaGridFuncoes();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Evento novoEvento = new Evento();

            novoEvento.Nome = txtTitulo.Text.Trim();
            novoEvento.DataEvento = Convert.ToDateTime(dtpDataEvento.Text);
            novoEvento.Observacao = txtObservacao.Text.Trim();
            novoEvento.Banda = carregaBandaSelecionada(); 
            novoEvento.SetList = carregaSetlistSelecionado(); 

            eventosController.AdicionarEvento(novoEvento);
        }

        private List<Musica> carregaSetlistSelecionado()
        {
            throw new NotImplementedException();
        }

        private List<IntegranteBanda> carregaBandaSelecionada()
        {
            throw new NotImplementedException();
        }
    }
}
