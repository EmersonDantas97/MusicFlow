namespace MusicFlow.View
{
    partial class frmCadastroIntegrante
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWhats = new System.Windows.Forms.TextBox();
            this.dgvFuncoes = new System.Windows.Forms.DataGridView();
            this.dgcSelecao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgcNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(170, 20);
            this.txtNome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Nascimento";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(12, 105);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(170, 20);
            this.txtDataNascimento.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Whats";
            // 
            // txtWhats
            // 
            this.txtWhats.Location = new System.Drawing.Point(12, 146);
            this.txtWhats.Name = "txtWhats";
            this.txtWhats.Size = new System.Drawing.Size(170, 20);
            this.txtWhats.TabIndex = 2;
            // 
            // dgvFuncoes
            // 
            this.dgvFuncoes.AllowUserToAddRows = false;
            this.dgvFuncoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncoes.ColumnHeadersVisible = false;
            this.dgvFuncoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcSelecao,
            this.dgcNome,
            this.dgcId});
            this.dgvFuncoes.Location = new System.Drawing.Point(14, 189);
            this.dgvFuncoes.Name = "dgvFuncoes";
            this.dgvFuncoes.RowHeadersVisible = false;
            this.dgvFuncoes.Size = new System.Drawing.Size(168, 240);
            this.dgvFuncoes.TabIndex = 3;
            // 
            // dgcSelecao
            // 
            this.dgcSelecao.HeaderText = "";
            this.dgcSelecao.Name = "dgcSelecao";
            this.dgcSelecao.Width = 30;
            // 
            // dgcNome
            // 
            this.dgcNome.HeaderText = "Função";
            this.dgcNome.Name = "dgcNome";
            this.dgcNome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgcNome.Width = 200;
            // 
            // dgcId
            // 
            this.dgcId.HeaderText = "Código";
            this.dgcId.Name = "dgcId";
            this.dgcId.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Funções";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "F4 - Adicionar";
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
            // frmCadastroIntegrante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 484);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvIntegrantes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFuncoes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtWhats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCadastroIntegrante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Músico";
            this.Load += new System.EventHandler(this.frmCadastroIntegrante_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroIntegrante_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWhats;
        private System.Windows.Forms.DataGridView dgvFuncoes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgcSelecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcINome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIFone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDataAniversario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIDataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcIFuncoes;
    }
}

