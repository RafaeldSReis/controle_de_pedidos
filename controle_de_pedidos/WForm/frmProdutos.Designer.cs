namespace controle_de_pedidos.WForm
{
    partial class frmProdutos
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
            this.components = new System.ComponentModel.Container();
            this.cboUnidade = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cboGProdutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboUnidade
            // 
            this.cboUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidade.Enabled = false;
            this.cboUnidade.FormattingEnabled = true;
            this.cboUnidade.ItemHeight = 13;
            this.cboUnidade.Items.AddRange(new object[] {
            "UN",
            "KG",
            "LT",
            "MT",
            "XX"});
            this.cboUnidade.Location = new System.Drawing.Point(375, 23);
            this.cboUnidade.MaxLength = 2;
            this.cboUnidade.Name = "cboUnidade";
            this.cboUnidade.Size = new System.Drawing.Size(64, 21);
            this.cboUnidade.TabIndex = 27;
            this.cboUnidade.Enter += new System.EventHandler(this.cboUnidade_Enter);
            this.cboUnidade.Leave += new System.EventHandler(this.cboUnidade_Leave);
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(88, 24);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(281, 21);
            this.txtDescricao.TabIndex = 21;
            this.txtDescricao.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtDescricao.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorVenda.Enabled = false;
            this.txtValorVenda.Location = new System.Drawing.Point(130, 64);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 21);
            this.txtValorVenda.TabIndex = 25;
            this.txtValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorVenda.Enter += new System.EventHandler(this.txtValorVenda_Enter);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorCompra.Enabled = false;
            this.txtValorCompra.Location = new System.Drawing.Point(11, 64);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(113, 21);
            this.txtValorCompra.TabIndex = 24;
            this.txtValorCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorCompra.Enter += new System.EventHandler(this.txtValorCompra_Enter);
            this.txtValorCompra.Leave += new System.EventHandler(this.txtValorCompra_Leave);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(11, 24);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(71, 21);
            this.txtId.TabIndex = 20;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Unidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Valor da venda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Valor da compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Descricao do Produto";
            // 
            // btnProximo
            // 
            this.btnProximo.Image = global::controle_de_pedidos.Properties.Resources.N;
            this.btnProximo.Location = new System.Drawing.Point(477, 122);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(30, 24);
            this.btnProximo.TabIndex = 43;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::controle_de_pedidos.Properties.Resources.P;
            this.btnAnterior.Location = new System.Drawing.Point(447, 122);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(30, 24);
            this.btnAnterior.TabIndex = 42;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Image = global::controle_de_pedidos.Properties.Resources.L;
            this.btnPrimeiro.Location = new System.Drawing.Point(417, 122);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(30, 24);
            this.btnPrimeiro.TabIndex = 41;
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnultimo
            // 
            this.btnultimo.Image = global::controle_de_pedidos.Properties.Resources.R;
            this.btnultimo.Location = new System.Drawing.Point(507, 122);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(30, 24);
            this.btnultimo.TabIndex = 40;
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::controle_de_pedidos.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(213, 99);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 48);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::controle_de_pedidos.Properties.Resources.Fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(543, 99);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(61, 48);
            this.btnFechar.TabIndex = 39;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::controle_de_pedidos.Properties.Resources.Pesquisar;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisa.Location = new System.Drawing.Point(351, 99);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(61, 48);
            this.btnPesquisa.TabIndex = 38;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = global::controle_de_pedidos.Properties.Resources.Gravar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvar.Location = new System.Drawing.Point(146, 99);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(61, 48);
            this.btnSalvar.TabIndex = 34;
            this.btnSalvar.Text = "Gravar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = global::controle_de_pedidos.Properties.Resources.Excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(284, 99);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 48);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::controle_de_pedidos.Properties.Resources.Alterar;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(79, 99);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 48);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::controle_de_pedidos.Properties.Resources.Incluir;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 99);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(61, 48);
            this.btnAdicionar.TabIndex = 31;
            this.btnAdicionar.Text = "&Incluir";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // cboGProdutos
            // 
            this.cboGProdutos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGProdutos.Enabled = false;
            this.cboGProdutos.FormattingEnabled = true;
            this.cboGProdutos.ItemHeight = 13;
            this.cboGProdutos.Location = new System.Drawing.Point(447, 23);
            this.cboGProdutos.MaxLength = 2;
            this.cboGProdutos.Name = "cboGProdutos";
            this.cboGProdutos.Size = new System.Drawing.Size(156, 21);
            this.cboGProdutos.TabIndex = 44;
            this.cboGProdutos.Enter += new System.EventHandler(this.cboGProdutos_Enter);
            this.cboGProdutos.Leave += new System.EventHandler(this.cboGProdutos_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Grupo de produtos";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 156);
            this.Controls.Add(this.cboGProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.cboUnidade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProdutos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProdutos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnultimo;
        public System.Windows.Forms.ComboBox cboUnidade;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cboGProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}