namespace MusicFlow.View
{
    partial class frmCadastroEvento
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvMusicas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.dtpDataEvento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBanda = new System.Windows.Forms.DataGridView();
            this.dgcSelecao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgcNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcIdIntegrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcIdFuncao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(12, 67);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(170, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Título";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data";
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
            // dgvMusicas
            // 
            this.dgvMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusicas.Location = new System.Drawing.Point(202, 51);
            this.dgvMusicas.Name = "dgvMusicas";
            this.dgvMusicas.RowHeadersVisible = false;
            this.dgvMusicas.Size = new System.Drawing.Size(564, 420);
            this.dgvMusicas.TabIndex = 7;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(12, 151);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(170, 45);
            this.txtObservacao.TabIndex = 2;
            // 
            // dtpDataEvento
            // 
            this.dtpDataEvento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEvento.Location = new System.Drawing.Point(12, 109);
            this.dtpDataEvento.Name = "dtpDataEvento";
            this.dtpDataEvento.Size = new System.Drawing.Size(170, 20);
            this.dtpDataEvento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Banda";
            // 
            // dgvBanda
            // 
            this.dgvBanda.AllowUserToAddRows = false;
            this.dgvBanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSelecao,
            this.dgcNome,
            this.dgcIdIntegrante,
            this.dgcIdFuncao});
            this.dgvBanda.Location = new System.Drawing.Point(12, 218);
            this.dgvBanda.Name = "dgvBanda";
            this.dgvBanda.RowHeadersVisible = false;
            this.dgvBanda.Size = new System.Drawing.Size(170, 219);
            this.dgvBanda.TabIndex = 3;
            // 
            // dgcSelecao
            // 
            this.dgcSelecao.HeaderText = "";
            this.dgcSelecao.Name = "dgcSelecao";
            this.dgcSelecao.Width = 35;
            // 
            // dgcNome
            // 
            this.dgcNome.HeaderText = "Nome/Função";
            this.dgcNome.Name = "dgcNome";
            this.dgcNome.ReadOnly = true;
            this.dgcNome.Width = 400;
            // 
            // dgcIdIntegrante
            // 
            this.dgcIdIntegrante.HeaderText = "Id Integrante";
            this.dgcIdIntegrante.Name = "dgcIdIntegrante";
            this.dgcIdIntegrante.ReadOnly = true;
            this.dgcIdIntegrante.Visible = false;
            // 
            // dgcIdFuncao
            // 
            this.dgcIdFuncao.HeaderText = "Id Funcao";
            this.dgcIdFuncao.Name = "dgcIdFuncao";
            this.dgcIdFuncao.ReadOnly = true;
            this.dgcIdFuncao.Visible = false;
            // 
            // frmCadastroEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 484);
            this.Controls.Add(this.dgvBanda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataEvento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvMusicas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitulo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadastroEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Evento";
            this.Load += new System.EventHandler(this.frmCadastroEvento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvMusicas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.DateTimePicker dtpDataEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvBanda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcSelecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIdIntegrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIdFuncao;
    }
}