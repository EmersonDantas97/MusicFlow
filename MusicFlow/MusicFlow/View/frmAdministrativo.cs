using MusicFlow.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicFlow
{
    public partial class frmAdministrativo : Form
    {
        public frmAdministrativo()
        {
            InitializeComponent();
        }

        private void musicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroMusica formulario = new frmCadastroMusica();
            formulario.ShowDialog();
        }

        private void integranteDaBandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroIntegrante formulario = new frmCadastroIntegrante();
            formulario.ShowDialog();
        }

        private void eventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroEvento formulario = new frmCadastroEvento();
            formulario.ShowDialog();
        }
    }
}
