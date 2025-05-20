namespace MusicFlow
{
    partial class frmAdministrativo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsAdm = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.integranteDaBandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsAdm
            // 
            this.mnsAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.mnsAdm.Location = new System.Drawing.Point(0, 0);
            this.mnsAdm.Name = "mnsAdm";
            this.mnsAdm.Size = new System.Drawing.Size(800, 24);
            this.mnsAdm.TabIndex = 0;
            this.mnsAdm.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.integranteDaBandaToolStripMenuItem,
            this.musicaToolStripMenuItem,
            this.eventoToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.ShortcutKeyDisplayString = "C";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "&Cadastros";
            // 
            // integranteDaBandaToolStripMenuItem
            // 
            this.integranteDaBandaToolStripMenuItem.Name = "integranteDaBandaToolStripMenuItem";
            this.integranteDaBandaToolStripMenuItem.ShortcutKeyDisplayString = "i";
            this.integranteDaBandaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.integranteDaBandaToolStripMenuItem.Text = "&Integrante da banda";
            this.integranteDaBandaToolStripMenuItem.Click += new System.EventHandler(this.integranteDaBandaToolStripMenuItem_Click);
            // 
            // musicaToolStripMenuItem
            // 
            this.musicaToolStripMenuItem.Name = "musicaToolStripMenuItem";
            this.musicaToolStripMenuItem.ShortcutKeyDisplayString = "m";
            this.musicaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.musicaToolStripMenuItem.Text = "&Musica";
            this.musicaToolStripMenuItem.Click += new System.EventHandler(this.musicaToolStripMenuItem_Click);
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.ShortcutKeyDisplayString = "e";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.eventoToolStripMenuItem.Text = "&Evento";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventoToolStripMenuItem1});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // eventoToolStripMenuItem1
            // 
            this.eventoToolStripMenuItem1.Name = "eventoToolStripMenuItem1";
            this.eventoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eventoToolStripMenuItem1.Text = "Eventos";
            // 
            // frmAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsAdm);
            this.MainMenuStrip = this.mnsAdm;
            this.Name = "frmAdministrativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrativo > MusicFlow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsAdm.ResumeLayout(false);
            this.mnsAdm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsAdm;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem integranteDaBandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem1;
    }
}

