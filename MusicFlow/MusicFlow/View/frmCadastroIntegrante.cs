using MusicFlow.Controller;
using System;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Models.IntegranteBanda i = new Models.IntegranteBanda();
            
            i.Nome = txtNome.Text;
            i.DataCadastro = DateTime.Now;
            i.DataAniversario = Convert.ToDateTime(txtDataNascimento.Text);
            i.Fone = txtWhats.Text;
            i.Status = Models.Status.Ativo;
            
            integranteBandaController.AdicionarIntegrante(i);
        }
        private void frmCadastroIntegrante_Load(object sender, EventArgs e)
        {
            CarregaGridFuncoes();
        }

        private async Task CarregaGridFuncoes()
        {
            foreach (var item in await funcoesController.Get())
            {
                dgvFuncoes.Rows.Add(false, item.Nome, item.Id);
            }
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
                    break;
            }
        }
    }
}
