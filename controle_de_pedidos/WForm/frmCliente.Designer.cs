namespace controle_de_pedidos.WForm
{
    partial class frmCliente
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CEP";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(506, 64);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(30, 13);
            this.lbl.TabIndex = 13;
            this.lbl.Text = "Data";
            // 
            // txtdata
            // 
            this.txtdata.Enabled = false;
            this.txtdata.Location = new System.Drawing.Point(506, 79);
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(92, 20);
            this.txtdata.TabIndex = 6;
            // 
            // txtCep
            // 
            this.txtCep.Enabled = false;
            this.txtCep.Location = new System.Drawing.Point(418, 31);
            this.txtCep.MaxLength = 9;
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(180, 20);
            this.txtCep.TabIndex = 2;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCep.Enter += new System.EventHandler(this.txtCep_Enter);
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome completo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.Enabled = false;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 13;
            this.cboEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cboEstado.Location = new System.Drawing.Point(436, 80);
            this.cboEstado.MaxLength = 2;
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(64, 21);
            this.cboEstado.TabIndex = 5;
            this.cboEstado.Enter += new System.EventHandler(this.cboEstado_Enter);
            this.cboEstado.Leave += new System.EventHandler(this.cboEstado_Leave);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(11, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(71, 20);
            this.txtId.TabIndex = 0;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEndereco
            // 
            this.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(11, 79);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(211, 20);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.Enter += new System.EventHandler(this.txtEndereco_Enter);
            this.txtEndereco.Leave += new System.EventHandler(this.txtEndereco_Leave);
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(228, 80);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(202, 20);
            this.txtCidade.TabIndex = 4;
            this.txtCidade.Enter += new System.EventHandler(this.txtCidade_Enter);
            this.txtCidade.Leave += new System.EventHandler(this.txtCidade_Leave);
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(88, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(324, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnultimo
            // 
            this.btnultimo.Image = global::controle_de_pedidos.Properties.Resources.R;
            this.btnultimo.Location = new System.Drawing.Point(502, 128);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(30, 24);
            this.btnultimo.TabIndex = 15;
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Image = global::controle_de_pedidos.Properties.Resources.L;
            this.btnPrimeiro.Location = new System.Drawing.Point(412, 128);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(30, 24);
            this.btnPrimeiro.TabIndex = 16;
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::controle_de_pedidos.Properties.Resources.P;
            this.btnAnterior.Location = new System.Drawing.Point(442, 128);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(30, 24);
            this.btnAnterior.TabIndex = 17;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = global::controle_de_pedidos.Properties.Resources.N;
            this.btnProximo.Location = new System.Drawing.Point(472, 128);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(30, 24);
            this.btnProximo.TabIndex = 18;
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::controle_de_pedidos.Properties.Resources.Cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(213, 106);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(61, 48);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::controle_de_pedidos.Properties.Resources.Fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFechar.Location = new System.Drawing.Point(537, 106);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(61, 48);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Image = global::controle_de_pedidos.Properties.Resources.Pesquisar;
            this.btnPesquisa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisa.Location = new System.Drawing.Point(351, 106);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(61, 48);
            this.btnPesquisa.TabIndex = 13;
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
            this.btnSalvar.Location = new System.Drawing.Point(146, 106);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(61, 48);
            this.btnSalvar.TabIndex = 10;
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
            this.btnExcluir.Location = new System.Drawing.Point(284, 106);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(61, 48);
            this.btnExcluir.TabIndex = 12;
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
            this.btnEditar.Location = new System.Drawing.Point(79, 106);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 48);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = global::controle_de_pedidos.Properties.Resources.Incluir;
            this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionar.Location = new System.Drawing.Point(12, 106);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(61, 48);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "&Incluir";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 164);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCliente_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisa;
        public System.Windows.Forms.ComboBox cboEstado;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCep;
        public System.Windows.Forms.TextBox txtdata;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.TextBox txtEndereco;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnultimo;
    }
}