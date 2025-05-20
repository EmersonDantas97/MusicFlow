namespace MusicFlow.View
{
    partial class frmCadastroMusica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVersao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTom = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
            this.dgcIId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcINome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcIFone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcIDataAniversario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcIDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcIFuncoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbTomOriginal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTemVs = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCompasso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBpm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCifra = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbVozPrincipal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 64);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(170, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Versão";
            // 
            // txtVersao
            // 
            this.txtVersao.Location = new System.Drawing.Point(12, 105);
            this.txtVersao.Name = "txtVersao";
            this.txtVersao.Size = new System.Drawing.Size(82, 20);
            this.txtVersao.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tom";
            // 
            // txtTom
            // 
            this.txtTom.Location = new System.Drawing.Point(12, 146);
            this.txtTom.Name = "txtTom";
            this.txtTom.Size = new System.Drawing.Size(82, 20);
            this.txtTom.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(14, 448);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "F1 - Salvar ";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(103, 448);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(79, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "F2 - Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(202, 25);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(564, 20);
            this.txtPesquisar.TabIndex = 6;
            // 
            // dgvIntegrantes
            // 
            this.dgvIntegrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntegrantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcIId,
            this.dgcINome,
            this.dgcIFone,
            this.dgcIDataAniversario,
            this.dgcIDataCadastro,
            this.dgcIFuncoes});
            this.dgvIntegrantes.Location = new System.Drawing.Point(202, 51);
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.RowHeadersVisible = false;
            this.dgvIntegrantes.Size = new System.Drawing.Size(564, 420);
            this.dgvIntegrantes.TabIndex = 7;
            // 
            // dgcIId
            // 
            this.dgcIId.HeaderText = "Id";
            this.dgcIId.Name = "dgcIId";
            this.dgcIId.ReadOnly = true;
            this.dgcIId.Width = 50;
            // 
            // dgcINome
            // 
            this.dgcINome.HeaderText = "Nome";
            this.dgcINome.Name = "dgcINome";
            this.dgcINome.ReadOnly = true;
            // 
            // dgcIFone
            // 
            this.dgcIFone.HeaderText = "Whats";
            this.dgcIFone.Name = "dgcIFone";
            this.dgcIFone.ReadOnly = true;
            // 
            // dgcIDataAniversario
            // 
            this.dgcIDataAniversario.HeaderText = "Aniversario";
            this.dgcIDataAniversario.Name = "dgcIDataAniversario";
            this.dgcIDataAniversario.ReadOnly = true;
            // 
            // dgcIDataCadastro
            // 
            this.dgcIDataCadastro.HeaderText = "Data Cadastro";
            this.dgcIDataCadastro.Name = "dgcIDataCadastro";
            this.dgcIDataCadastro.ReadOnly = true;
            // 
            // dgcIFuncoes
            // 
            this.dgcIFuncoes.HeaderText = "Funções";
            this.dgcIFuncoes.Name = "dgcIFuncoes";
            this.dgcIFuncoes.ReadOnly = true;
            this.dgcIFuncoes.Width = 1000;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(692, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "F3 - Pesquisar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(12, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(170, 20);
            this.txtCodigo.TabIndex = 8;
            // 
            // cmbTomOriginal
            // 
            this.cmbTomOriginal.FormattingEnabled = true;
            this.cmbTomOriginal.Items.AddRange(new object[] {
            "À verificar",
            "Sim",
            "Não"});
            this.cmbTomOriginal.Location = new System.Drawing.Point(100, 146);
            this.cmbTomOriginal.Name = "cmbTomOriginal";
            this.cmbTomOriginal.Size = new System.Drawing.Size(82, 21);
            this.cmbTomOriginal.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tom original";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tem VS";
            // 
            // cmbTemVs
            // 
            this.cmbTemVs.FormattingEnabled = true;
            this.cmbTemVs.Items.AddRange(new object[] {
            "À verificar",
            "Sim",
            "Não"});
            this.cmbTemVs.Location = new System.Drawing.Point(100, 105);
            this.cmbTemVs.Name = "cmbTemVs";
            this.cmbTemVs.Size = new System.Drawing.Size(82, 21);
            this.cmbTemVs.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Compasso";
            // 
            // txtCompasso
            // 
            this.txtCompasso.Location = new System.Drawing.Point(12, 187);
            this.txtCompasso.Name = "txtCompasso";
            this.txtCompasso.Size = new System.Drawing.Size(82, 20);
            this.txtCompasso.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Bpm";
            // 
            // txtBpm
            // 
            this.txtBpm.Location = new System.Drawing.Point(100, 187);
            this.txtBpm.Name = "txtBpm";
            this.txtBpm.Size = new System.Drawing.Size(82, 20);
            this.txtBpm.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Vídeo";
            // 
            // txtVideo
            // 
            this.txtVideo.Location = new System.Drawing.Point(12, 226);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(170, 20);
            this.txtVideo.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Cifra";
            // 
            // txtCifra
            // 
            this.txtCifra.Location = new System.Drawing.Point(12, 265);
            this.txtCifra.Name = "txtCifra";
            this.txtCifra.Size = new System.Drawing.Size(170, 20);
            this.txtCifra.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 346);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(170, 86);
            this.txtObservacao.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Voz principal";
            // 
            // cmbVozPrincipal
            // 
            this.cmbVozPrincipal.FormattingEnabled = true;
            this.cmbVozPrincipal.Items.AddRange(new object[] {
            "À verificar",
            "Sim",
            "Não"});
            this.cmbVozPrincipal.Location = new System.Drawing.Point(12, 304);
            this.cmbVozPrincipal.Name = "cmbVozPrincipal";
            this.cmbVozPrincipal.Size = new System.Drawing.Size(170, 21);
            this.cmbVozPrincipal.TabIndex = 37;
            // 
            // frmCadastroMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 484);
            this.Controls.Add(this.cmbVozPrincipal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCifra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtVideo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBpm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCompasso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTemVs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTomOriginal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvIntegrantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVersao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadastroMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Músico";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroMusica_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTom;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcINome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIFone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDataAniversario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIFuncoes;

        #endregion

        private System.Windows.Forms.ComboBox cmbTomOriginal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTemVs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCompasso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBpm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCifra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbVozPrincipal;
    }
}