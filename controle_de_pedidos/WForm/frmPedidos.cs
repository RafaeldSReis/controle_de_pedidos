using controle_de_pedidos.BLL;
using controle_de_pedidos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_pedidos.WForm
{
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        private void HabilitarCampos()
        {
            txtDescricao.Enabled = true;
            txtId.Enabled = true;
            txtValorVenda.Enabled = true;
            txtClieID.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAdicionar.Enabled = false;
            txtdata.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void RMHabilitarCampos()
        {
            txtDescricao.Enabled = false;
            txtId.Enabled = false;
            txtClieID.Enabled = false;
            txtValorVenda.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAdicionar.Enabled = true;
        }

        private void EditarCampos()
        {
            txtDescricao.Enabled = false;
            txtId.Enabled = false;
            txtValorVenda.Enabled = false;
            txtClieID.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAdicionar.Enabled = true;
            txtdata.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void LimparDados()
        {
            txtId.Clear();
            txtDescricao.Clear();
            txtValorVenda.Clear();
            txtdata.Text = string.Empty;
        }

        private void Registro(int ID = 0)
        {
            // para carregar quando eu quiser 
            Pedidos pedidos = new PedidosBLL().Pesquisar(ID);
            PreenceCampos(pedidos);
        }

        private void PreenceCampos(Pedidos pedidos)
        {
            txtId.Text = pedidos.PediID.ToString();
            txtDescricao.Text = pedidos.PediObservacao;
            txtClieID.Text = pedidos.PediCliente.ToString();
            txtValorVenda.Text = pedidos.PediValorTotal.ToString();
            txtdata.Text = pedidos.PediData.ToString("dd/MM/yyyy");
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
            Pedidos pedidos = new Pedidos();
            PedidosBLL pedidosBLL = new PedidosBLL();

            if (txtId.Text.Length > 0)
            {
                Editar();
            }
            else
            {
                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    errorProvider1.SetError(txtDescricao, "O campo descrição deve ser preenchido");
                }
                else
                {
                    errorProvider1.SetError(txtDescricao, string.Empty);
                }

                if (string.IsNullOrEmpty(txtValorVenda.Text))
                {
                    errorProvider1.SetError(txtValorVenda, "O Valor deve ser preenchido");
                }
                else
                {
                    errorProvider1.SetError(txtValorVenda, string.Empty);
                }

                if (errorProvider1.HasErrors(this))
                    return;

                pedidos.PediObservacao = txtDescricao.Text;
                pedidos.PediValorTotal = double.Parse(txtValorVenda.Text);
                pedidos.PediCliente = int.Parse(txtClieID.Text);            
                
                pedidos.PediData = DateTime.Parse(txtdata.Text);
                pedidosBLL.Salvar(pedidos);

                MessageBox.Show("O Pedido foi salvo com Sucesso!");
                Registro(new PedidosBLL().Ultimo());
                EditarCampos();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Editar()
        {
            Pedidos pedidos = new Pedidos();
            PedidosBLL pedidosBLL = new PedidosBLL();

            
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                errorProvider1.SetError(txtDescricao, "O campo descrição deve ser preenchido");
            }
            else
            {
                errorProvider1.SetError(txtDescricao, string.Empty);
            }

            if (string.IsNullOrEmpty(txtValorVenda.Text))
            {
                errorProvider1.SetError(txtValorVenda, "O Valor deve ser preenchido");
            }
            else
            {
                errorProvider1.SetError(txtValorVenda, string.Empty);
            }

            if (errorProvider1.HasErrors(this))
                return;

            pedidos.PediID = int.Parse(txtId.Text);
            pedidos.PediObservacao = txtDescricao.Text;
            pedidos.PediValorTotal = double.Parse(txtValorVenda.Text);
            pedidos.PediCliente = int.Parse(txtClieID.Text);

            pedidos.PediData = DateTime.Parse(txtdata.Text);
            pedidosBLL.Editar(pedidos);

            MessageBox.Show("O Pedido foi Editado com Sucesso!");
                EditarCampos();
            }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtDescricao.Focus();
        }

        private void Excluir()
        {
            Pedidos pedidos = new Pedidos();
            PedidosBLL pedidosBLL = new PedidosBLL();

            if (txtId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione um registro para poder removê-lo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja realmente excluir esse registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                pedidos.PediID = Convert.ToInt32(txtId.Text);

                pedidosBLL.Excluir(pedidos);

                MessageBox.Show("Dados Removidos com Sucesso!");
                Registro(new PedidosBLL().Ultimo());
                EditarCampos();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void frmPedidos_Load(object sender, EventArgs e)
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
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            Registro(new PedidosBLL().Ultimo());
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Registro(new PedidosBLL().Proximo(int.Parse(txtId.Text)));
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Registro(new PedidosBLL().Anterior(int.Parse(txtId.Text)));
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            Registro(new PedidosBLL().Primeiro());
        }
    }
}
