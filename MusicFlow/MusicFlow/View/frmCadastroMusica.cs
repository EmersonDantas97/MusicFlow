using MusicFlow.Controller;
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
    public partial class frmCadastroMusica : Form
    {
        MusicasController musicaController = new MusicasController();
        public frmCadastroMusica()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
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
    }
}
