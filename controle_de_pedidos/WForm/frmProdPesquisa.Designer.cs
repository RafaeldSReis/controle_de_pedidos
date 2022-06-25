namespace controle_de_pedidos.WForm
{
    partial class frmProdPesquisa
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbProcurar = new System.Windows.Forms.ComboBox();
            this.btnVolta = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPesquisa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cadastrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GProdutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Conteúdo";
            // 
            // cbProcurar
            // 
            this.cbProcurar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProcurar.FormattingEnabled = true;
            this.cbProcurar.Items.AddRange(new object[] {
            "F2 - Código",
            "F3 - Descrição",
            "F4 - Valor Compra"});
            this.cbProcurar.Location = new System.Drawing.Point(14, 25);
            this.cbProcurar.Name = "cbProcurar";
            this.cbProcurar.Size = new System.Drawing.Size(121, 21);
            this.cbProcurar.TabIndex = 23;
            this.cbProcurar.SelectedIndexChanged += new System.EventHandler(this.cbProcurar_SelectedIndexChanged);
            // 
            // btnVolta
            // 
            this.btnVolta.Image = global::controle_de_pedidos.Properties.Resources.Fechar;
            this.btnVolta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVolta.Location = new System.Drawing.Point(577, 294);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(61, 48);
            this.btnVolta.TabIndex = 22;
            this.btnVolta.Text = "Fechar";
            this.btnVolta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVolta.UseVisualStyleBackColor = true;
            this.btnVolta.Click += new System.EventHandler(this.btnVolta_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(564, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 32);
            this.btnPesquisar.TabIndex = 21;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Location = new System.Drawing.Point(141, 25);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(399, 20);
            this.txtPesquisa.TabIndex = 20;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Pesquisar Por:";
            // 
            // dgvPesquisa
            // 
            this.dgvPesquisa.AllowUserToAddRows = false;
            this.dgvPesquisa.AllowUserToDeleteRows = false;
            this.dgvPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.Endereco,
            this.Cep,
            this.Cadastrado,
            this.GProdutos});
            this.dgvPesquisa.Location = new System.Drawing.Point(14, 57);
            this.dgvPesquisa.MultiSelect = false;
            this.dgvPesquisa.Name = "dgvPesquisa";
            this.dgvPesquisa.ReadOnly = true;
            this.dgvPesquisa.RowHeadersVisible = false;
            this.dgvPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPesquisa.Size = new System.Drawing.Size(624, 231);
            this.dgvPesquisa.TabIndex = 18;
            this.dgvPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPesquisa_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 40;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "ProdDescricao";
            this.Nome.HeaderText = "Descrição do Produto";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nome.Width = 140;
            // 
            // Endereco
            // 
            this.Endereco.DataPropertyName = "ProdUnidade";
            this.Endereco.HeaderText = "Unidade";
            this.Endereco.Name = "Endereco";
            this.Endereco.ReadOnly = true;
            this.Endereco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cep
            // 
            this.Cep.DataPropertyName = "ProdValorCompra";
            this.Cep.HeaderText = "Valor Compra";
            this.Cep.Name = "Cep";
            this.Cep.ReadOnly = true;
            this.Cep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Cadastrado
            // 
            this.Cadastrado.DataPropertyName = "ProdValorVenda";
            this.Cadastrado.HeaderText = "Valor Venda";
            this.Cadastrado.Name = "Cadastrado";
            this.Cadastrado.ReadOnly = true;
            this.Cadastrado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Cadastrado.Width = 90;
            // 
            // GProdutos
            // 
            this.GProdutos.DataPropertyName = "GrupDescricao";
            this.GProdutos.HeaderText = "Grupo de Produtos";
            this.GProdutos.Name = "GProdutos";
            this.GProdutos.ReadOnly = true;
            this.GProdutos.Width = 150;
            // 
            // frmProdPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProcurar);
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPesquisa);
            this.Name = "frmProdPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de Produtos";
            this.Load += new System.EventHandler(this.frmProdPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProcurar;
        private System.Windows.Forms.Button btnVolta;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cadastrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn GProdutos;
    }
}