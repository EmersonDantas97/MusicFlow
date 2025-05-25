using MusicFlow.Controller;
using MusicFlow.Models;
using System;
using System.Windows.Forms;

namespace MusicFlow.View
{
    public partial class frmCadastroMusica : Form
    {
        MusicasController musicaController = new MusicasController();
        public frmCadastroMusica()
        {
            InitializeComponent();
        }

        #region "Métodos para abstração"
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

        private void preparaTela()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtVersao.Clear();
            txtTom.Clear();
            txtCompasso.Clear();
            txtBpm.Clear();
            txtVideo.Clear();
            txtCifra.Clear();
            txtObservacao.Clear();
            cmbTemVs.SelectedIndex = 0;
            cmbTomOriginal.SelectedIndex = 0;
            cmbVozPrincipal.SelectedIndex = 0;

            atualizaGridMusicas();
        } 
        #endregion

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Musica novaMusica = new Musica();

            novaMusica.Nome = txtTitulo.Text.Trim();
            novaMusica.Status = Status.Ativo;
            novaMusica.DataCadastro = DateTime.Now;
            //TODO: Ajustar para pegar o id do integrante ativo que está na função das vozes carregue na propriedade "VozPrincipal".
            novaMusica.VozPrincipal = 8;
            novaMusica.Bpm = Convert.ToInt32(txtBpm.Text.Trim());
            novaMusica.Versao = txtVersao.Text.Trim();
            novaMusica.Compasso = txtCompasso.Text.Trim();
            novaMusica.Tom = txtTom.Text.Trim();
            novaMusica.LinkVideo = txtVideo.Text.Trim();
            novaMusica.LinkCifra = txtCifra.Text.Trim();
            novaMusica.TomOriginal = (TomOriginal)cmbTomOriginal.SelectedIndex;
            novaMusica.TemVs = (TemVs)cmbTemVs.SelectedIndex;
            novaMusica.Observacao = txtObservacao.Text.Trim();

            int novoId = musicaController.AdicionarMusica(novaMusica);

            txtCodigo.Text = novoId.ToString();

            if (novoId != 0)
            {
                MessageBox.Show("Cadastro realizado com SUCESSO!","Cadasro realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                preparaTela();
            }
            else
            {
                MessageBox.Show("Cadastro NÃO REALIZADO!\n\nVerifique as informações e TENTE NOVAMENTE!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCadastroMusica_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnSalvar.PerformClick();
                    break;
                case Keys.F2:
                    btnExcluir.PerformClick();
                    break;
                case Keys.F3:
                    txtPesquisar.Focus();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void frmCadastroMusica_Load(object sender, EventArgs e)
        {
            atualizaGridMusicas();
        }
    }
}
