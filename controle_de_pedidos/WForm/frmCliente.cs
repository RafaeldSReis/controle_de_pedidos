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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();         
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtCep.Enabled = true;
            txtCidade.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            cboEstado.Enabled = true;
            btnAdicionar.Enabled = false;
            txtdata.Text = DateTime.Now.ToString("dd/MM/yyyy");          
        }

        private void RMHabilitarCampos()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtCep.Enabled = false;
            txtCidade.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            cboEstado.Enabled = false;
            btnCancelar.Enabled = false;
            btnAdicionar.Enabled = true;
        }

        private void EditarCampos()
        {
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtCep.Enabled = false;
            txtCidade.Enabled = false;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            cboEstado.Enabled = false;
            btnAdicionar.Enabled = true;
            txtdata.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

                
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                LimparDados();
                HabilitarCampos();
                txtNome.Focus();
            }
            else
            {
                HabilitarCampos();
                txtNome.Focus();
            }
        }

        private void Salvar()
        {
            Cliente cliente = new Cliente();
            ClientesBLL clienteBLL = new ClientesBLL();

            if (txtId.Text.Length > 0)
            {
                Editar();
            }
            else
            {                
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    errorProvider1.SetError(txtNome, "O nome deve ser preenchido");
                }
                else
                {
                    errorProvider1.SetError(txtNome, string.Empty);
                }
               
                if (string.IsNullOrEmpty(txtEndereco.Text))
                {
                    errorProvider1.SetError(txtEndereco, "O Endereço deve ser preenchido");
                }
                else
                {
                    errorProvider1.SetError(txtEndereco, string.Empty);
                }
                
                if (string.IsNullOrEmpty(txtCep.Text))
                {
                    errorProvider1.SetError(txtCep, "O Cep deve ser preenchido");
                }
                else
                {
                    errorProvider1.SetError(txtCep, string.Empty);
                }
                
                if (string.IsNullOrEmpty(txtCidade.Text))
                {
                    errorProvider1.SetError(txtCidade, "O Cidade deve ser preenchido");
                }
                else
                {
                    errorProvider1.SetError(txtCidade, string.Empty);
                }
               
                if (errorProvider1.HasErrors(this))
                    return;

                cliente.ClieNome = txtNome.Text;
                cliente.ClieEndereco = txtEndereco.Text;
                cliente.ClieCep = txtCep.Text;
                cliente.ClieCidade = txtCidade.Text;
                cliente.ClieEstado = cboEstado.Text;
                cliente.ClieDataCadastro = DateTime.Parse(txtdata.Text);
                clienteBLL.Salvar(cliente);

                MessageBox.Show("O Cliente foi salvo com Sucesso!");                
                Registro(new ClientesBLL().Ultimo());
                EditarCampos();
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();          
        }

        private void LimparDados()
        {
            txtId.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            cboEstado.SelectedIndex = -1;
            txtdata.Text = string.Empty;
        }        

        private void Editar()
        {
            Cliente cliente = new Cliente();
            ClientesBLL clienteBLL = new ClientesBLL();

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "O nome deve ser preenchido");
            }
            else
            {
                errorProvider1.SetError(txtNome, string.Empty);
            }
          
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                errorProvider1.SetError(txtEndereco, "O Endereço deve ser preenchido");
            }
            else
            {
                errorProvider1.SetError(txtEndereco, string.Empty);
            }
           
            if (string.IsNullOrEmpty(txtCep.Text))
            {
                errorProvider1.SetError(txtCep, "O Cep deve ser preenchido");
            }
            else
            {
                errorProvider1.SetError(txtCep, string.Empty);
            }
            
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                errorProvider1.SetError(txtCidade, "O Cidade deve ser preenchido");
            }
            else
            {
                errorProvider1.SetError(txtCidade, string.Empty);
            }

            if (errorProvider1.HasErrors(this))
                return;

            cliente.ClieCodigo = Convert.ToInt32(txtId.Text);
            cliente.ClieNome = txtNome.Text;
            cliente.ClieEndereco = txtEndereco.Text;
            cliente.ClieCep = txtCep.Text;
            cliente.ClieCidade = txtCidade.Text;
            cliente.ClieEstado = cboEstado.Text;
            cliente.ClieDataCadastro = DateTime.Parse(txtdata.Text);
            clienteBLL.Editar(cliente);

            MessageBox.Show("O Cliente foi Editado com Sucesso!");           
            EditarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            txtNome.Focus();
        }

        private void Excluir()
        {
            Cliente cliente = new Cliente();
            ClientesBLL funcionarioBLL = new ClientesBLL();

            if (txtId.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Selecione um registro para poder removê-lo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("Deseja realmente excluir esse registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {

            }
            else
            {
                cliente.ClieCodigo = Convert.ToInt32(txtId.Text);

                funcionarioBLL.Excluir(cliente);

                MessageBox.Show("Dados Removidos com Sucesso!");
                Registro(new ClientesBLL().Ultimo());
                EditarCampos();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // cor de fundo TextBox   
        private void txtNome_Enter(object sender, EventArgs e)
        {            
            txtNome.BackColor = Color.Beige;
        }
        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.BackColor = Color.White;
        } 
        private void txtCep_Enter(object sender, EventArgs e)
        {
            txtCep.BackColor = Color.Beige;
        }
        private void txtCep_Leave(object sender, EventArgs e)
        {
            txtCep.BackColor = Color.White;
        }
        private void txtEndereco_Enter(object sender, EventArgs e)
        {
            txtEndereco.BackColor = Color.Beige;
        }
        private void txtEndereco_Leave(object sender, EventArgs e)
        {
            txtEndereco.BackColor = Color.White;
        }
        private void txtCidade_Enter(object sender, EventArgs e)
        {
            txtCidade.BackColor = Color.Beige;
        }
        private void txtCidade_Leave(object sender, EventArgs e)
        {
            txtCidade.BackColor = Color.White;
        }
        private void cboEstado_Enter(object sender, EventArgs e)
        {
            cboEstado.BackColor = Color.Beige;
        }
        private void cboEstado_Leave(object sender, EventArgs e)
        {
            cboEstado.BackColor = Color.White;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro(int.Parse(txtId.Text)) ;
            EditarCampos();
        }       
        
        // Mover pelo [Enter]
        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
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
                    break ;
            }
        }
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            frmCliePesquisa frm = new frmCliePesquisa();
            frm.ShowDialog();
            Registro(frm.Resultado);
                      
        }


        private void Registro(int ID = 0)
        {           
                // para carregar quando eu quiser 
                Cliente cliente = new ClientesBLL().Pesquisar(ID);
                PreenceCampos(cliente);            
        }


        private void PreenceCampos(Cliente cliente)
        {
            txtId.Text = cliente.ClieCodigo.ToString();
            txtNome.Text = cliente.ClieNome;
            txtCep.Text = cliente.ClieCep;
            txtEndereco.Text = cliente.ClieEndereco;
            txtCidade.Text = cliente.ClieCidade;
            cboEstado.Text = cliente.ClieEstado;
            txtdata.Text = cliente.ClieDataCadastro.ToString("dd/MM/yyyy");           
        }
        // txtCep recebe somente numeros
        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
          
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (txtId.Text.Length > 0)
            {
                RMHabilitarCampos();                  
            }
            else
            {
                EditarCampos();
                txtNome.Focus();
            }
            Registro();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            Registro(new ClientesBLL().Ultimo());
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Registro(new ClientesBLL().Proximo(int.Parse(txtId.Text)));
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Registro(new ClientesBLL().Anterior(int.Parse(txtId.Text)));
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            Registro(new ClientesBLL().Primeiro());
        }
    }
}
