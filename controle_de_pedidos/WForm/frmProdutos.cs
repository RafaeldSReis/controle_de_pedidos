using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controle_de_pedidos.Entidades;
using controle_de_pedidos.BLL;



namespace controle_de_pedidos.WForm
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtValorCompra.Enabled = true;            
            txtValorVenda.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            cboUnidade.Enabled = true;
            btnAdicionar.Enabled = false;
            cboGProdutos.Enabled = true;
        }

        private void RMHabilitarCampos()
        {
            txtDescricao.Enabled = false;
            txtValorCompra.Enabled = false;            
            txtValorVenda.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            cboUnidade.Enabled = false;
            btnCancelar.Enabled = false;
            btnAdicionar.Enabled = true;
            cboGProdutos.Enabled = false;
        }

        private void EditarCampos()
        {
            txtDescricao.Enabled = false;
            txtValorCompra.Enabled = false;            
            txtValorVenda.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            cboUnidade.Enabled = false;
            btnAdicionar.Enabled = true;
            cboGProdutos.Enabled = false;
            
        }

        private void LimparDados()
        {
            txtId.Clear();
            txtDescricao.Clear();
            txtValorCompra.Clear();
            txtValorVenda.Clear();            
            cboUnidade.SelectedIndex = -1;
            cboGProdutos.SelectedIndex = -1;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                LimparDados();
                HabilitarCampos();
                txtDescricao.Focus();
            }
            else
            {
                HabilitarCampos();
                txtDescricao.Focus();
            }
        }

        private void Salvar()
        {
            Produtos produtos = new Produtos();
            ProdutosBLL produtosBLL = new ProdutosBLL();

            if (txtId.Text.Length > 0)
            {
                Editar();
            }
            else
            {
                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    errorProvider1.SetError(txtDescricao, "O nome deve ser preenchido");
                }
                else
                {
                    errorProvider1.SetError(txtDescricao, string.Empty);
                }

                if (string.IsNullOrEmpty(txtValorCompra.Text))
                {
                    errorProvider1.SetError(txtValorCompra, "O valor da compra deve ser preenchido");
                }
                else
                {
                    errorProvider1.SetError(txtValorCompra, string.Empty);
                }

                if (string.IsNullOrEmpty(txtValorVenda.Text))
                {
                    errorProvider1.SetError(txtValorVenda, "O valor da venda deve ser preenchido");
                }
                else
                {
                    errorProvider1.SetError(txtValorVenda, string.Empty);
                }               

                if (errorProvider1.HasErrors(this))
                    return;

                produtos.prodDescricao = txtDescricao.Text;
                produtos.prodValorCompra = double.Parse(txtValorCompra.Text);
                produtos.prodValorVenda = double.Parse(txtValorVenda.Text);
                produtos.prodUnidade = cboUnidade.Text;
                produtos.ProdutosGrupos.GrupID = (cboGProdutos.SelectedItem as dynamic).GrupID;                
                produtos.ProdutosGrupos.GrupDescricao = cboGProdutos.Text;
                produtosBLL.Salvar(produtos);

                MessageBox.Show("O Produto foi salvo com Sucesso!");
                Registro(new ProdutosBLL().Ultimo());
                EditarCampos();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Editar()
        {
            Produtos produtos = new Produtos();
            ProdutosBLL produtosBLL = new ProdutosBLL();

                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    errorProvider1.SetError(txtDescricao, "A Descrição deve ser preenchido");
                }
                else
                {
                   errorProvider1.SetError(txtDescricao, string.Empty);
                }

                if (string.IsNullOrEmpty(txtValorCompra.Text))
                {
                   errorProvider1.SetError(txtValorCompra, "O valor da compra deve ser preenchido");
                }
                else
                {
                   errorProvider1.SetError(txtValorCompra, string.Empty);
                }

                if (string.IsNullOrEmpty(txtValorVenda.Text))
                {
                   errorProvider1.SetError(txtValorVenda, "O valor da venda deve ser preenchido");
                }
                else
                {
                   errorProvider1.SetError(txtValorVenda, string.Empty);
                }

                if (errorProvider1.HasErrors(this))
                   return;

                produtos.prodDescricao = txtDescricao.Text;
                produtos.prodValorCompra = double.Parse(txtValorCompra.Text);
                produtos.prodValorVenda = double.Parse(txtValorVenda.Text);
                produtos.prodUnidade = cboUnidade.Text;
                produtos.ProdutosGrupos.GrupID = (cboGProdutos.SelectedItem as dynamic).GrupID;
                produtos.ProdutosGrupos.GrupDescricao = cboGProdutos.Text;
                produtosBLL.Editar(produtos);

                MessageBox.Show("O Produto foi editado com Sucesso!");
                Registro(produtosBLL.Ultimo());
                EditarCampos();            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtDescricao.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            ProdutosBLL produtosBLL = new ProdutosBLL();

            if (txtId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione um registro para poder removê-lo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja realmente excluir esse registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                produtos.ProdCodigo = Convert.ToInt32(txtId.Text);

                produtosBLL.Excluir(produtos);

                MessageBox.Show("Dados Removidos com Sucesso!");
                Registro(new ProdutosBLL().Ultimo());
                EditarCampos();
            }          

        }
        // Cor de Fundo
        private void txtNome_Enter(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.Beige;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtDescricao.BackColor = Color.White;
        }

        private void txtValorCompra_Enter(object sender, EventArgs e)
        {
            
            txtValorCompra.BackColor = Color.Beige;
        }

        private void txtValorCompra_Leave(object sender, EventArgs e)
        {
            
            txtValorCompra.BackColor = Color.White;
        }

        private void txtValorVenda_Enter(object sender, EventArgs e)
        {
            txtValorVenda.BackColor = Color.Beige;
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            txtValorVenda.BackColor = Color.White;
        }

        private void cboUnidade_Enter(object sender, EventArgs e)
        {
            cboUnidade.BackColor = Color.Beige;
        }

        private void cboUnidade_Leave(object sender, EventArgs e)
        {
            cboUnidade.BackColor = Color.White;
        }

        private void cboGProdutos_Enter(object sender, EventArgs e)
        {
            cboGProdutos.BackColor = Color.Beige;
        }

        private void cboGProdutos_Leave(object sender, EventArgs e)
        {
           cboGProdutos.BackColor = Color.White;
        }

        private void frmProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (!e.Control)
                    {
                        e.SuppressKeyPress = true;
                        e.Handled = true;
                        this.ProcessTabKey(true);
                    }
                    break;
                case Keys.F3:
                    if (!btnSalvar.Enabled)
                    {
                        btnPesquisa_Click(sender, e);
                    }
                    break;
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmProdPesquisa frm = new frmProdPesquisa();
            frm.ShowDialog();
            Registro(frm.Resultado);
        }

        private void Registro(int ID = 0)
        {
            // para carregar quando eu quiser 
            Produtos produtos = new ProdutosBLL().Pesquisar(ID);
            if(produtos.ProdCodigo != 0)
             PreenceCampos(produtos);
        }

        private void PreenceCampos(Produtos produtos)
        {
            txtId.Text = produtos.ProdCodigo.ToString();
            txtDescricao.Text = produtos.prodDescricao;
            txtValorCompra.Text = produtos.prodValorCompra.ToString("N2");
            txtValorVenda.Text = produtos.prodValorVenda.ToString("N2");
            cboUnidade.Text = produtos.prodUnidade;
            cboGProdutos.Text = produtos.ProdutosGrupos.GrupDescricao.ToString();           
        }
        
        private void frmProdutos_Load(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                RMHabilitarCampos();
            }
            else
            {
                EditarCampos();
                txtDescricao.Focus();
            }
            Registro();

            cboGProdutos.DisplayMember = "GrupDescricao";
            cboGProdutos.ValueMember = "GrupID";
            cboGProdutos.DataSource = new BLL.ProdutosGrupos().CarregarGrid("");


        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            Registro(new ProdutosBLL().Ultimo());
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Registro(new ProdutosBLL().Proximo(int.Parse(txtId.Text)));
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Registro(new ProdutosBLL().Anterior(int.Parse(txtId.Text)));
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            Registro(new ProdutosBLL().Primeiro());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           Registro(new ProdutosBLL().Ultimo());
            EditarCampos(); 
        }
    }
}
