using MusicFlow.Controller;
using MusicFlow.Models;
using MusicFlow.Repository;
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
        private readonly MusicasController musicaController = new MusicasController();

        public frmCadastroEvento()
        {
            InitializeComponent();
        }

        private void atualizaGridMusicas()
        {
            var listaDeMusicas = musicaController.BuscarMusicasAtivas();

            dgvMusicas.Rows.Clear();

            foreach (var musica in listaDeMusicas)
            {
                int indiceDaLinha = dgvMusicas.Rows.Add();

                dgvMusicas.Rows[indiceDaLinha].Cells[0].Value = musica.Id;
                dgvMusicas.Rows[indiceDaLinha].Cells[1].Value = musica.Nome;
                dgvMusicas.Rows[indiceDaLinha].Cells[2].Value = musica.Versao;
                dgvMusicas.Rows[indiceDaLinha].Cells[3].Value = musica.Tom;
                dgvMusicas.Rows[indiceDaLinha].Cells[4].Value = musica.VozPrincipal;
                dgvMusicas.Rows[indiceDaLinha].Cells[5].Value = musica.Bpm;
                dgvMusicas.Rows[indiceDaLinha].Cells[6].Value = musica.Observacao;
                dgvMusicas.Rows[indiceDaLinha].Cells[7].Value = musica.TomOriginal;
                dgvMusicas.Rows[indiceDaLinha].Cells[8].Value = musica.DataCadastro;
                dgvMusicas.Rows[indiceDaLinha].Cells[9].Value = musica.Compasso;
                dgvMusicas.Rows[indiceDaLinha].Cells[10].Value = musica.TemVs;
                dgvMusicas.Rows[indiceDaLinha].Cells[11].Value = musica.LinkVideo;
                dgvMusicas.Rows[indiceDaLinha].Cells[12].Value = musica.LinkCifra;
            }
        }
        private async void atualizaGridFuncoes()
        {
            var funcoesIntegrantes = await integranteBandaController.BuscarIntegrantesAtivos();

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
            atualizaGridMusicas();
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
