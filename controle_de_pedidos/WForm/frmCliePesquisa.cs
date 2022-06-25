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
    public partial class frmCliePesquisa : Form
    {
        public frmCliente FrmCliente= null;
        public int Resultado { get; set; } //

        public frmCliePesquisa()
        {
            InitializeComponent();
            txtPesquisa.Focus();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Busca uma lista de Clientes no banco de dados
        private void CarregaGrid(List<Cliente> lstClientes)
        {
            try
            {
                dgvPesquisa.AutoGenerateColumns = false;
                dgvPesquisa.DataSource = lstClientes;
                dgvPesquisa.RowsDefaultCellStyle.BackColor = Color.White;

                dgvPesquisa.RowHeadersVisible = false;
                dgvPesquisa.AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender;
                if (dgvPesquisa.Rows.Count == 0)
                {
                    MessageBox.Show("Registro não encontrado!");
                    txtPesquisa.Focus();
                }
                else
                {
                    dgvPesquisa.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        // Pesquisa no Banco de Dados e carrega na Grid
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string strWhere = "";
            if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                switch (cbProcurar.SelectedIndex)
                {
                    case 0: 
                        strWhere = (" WHERE ClieCodigo=" + txtPesquisa.Text);
                        break;
                    case 1: 
                        strWhere = ("WHERE ClieNome LIKE '%" + txtPesquisa.Text + "%'"); 
                        break;
                }           
                CarregaGrid(new ClientesBLL().CarregaGrid(strWhere));
            }
            else
            {
                MessageBox.Show("Preencha o campo Pesquisa!");
            }
        }
       
        private void dgvPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int intIndex = e.RowIndex;

            if (intIndex != -1)
            {
                Resultado = Convert.ToInt32(dgvPesquisa.Rows[intIndex].Cells["ID"].Value);

                this.Close();
            }
           
        }

        private void frmPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        // Selecionando com F2,F3,F4,F5
        private void frmPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2:
                    cbProcurar.SelectedIndex = 0;
                    txtPesquisa.Visible = true;
                    txtPesquisa.TextAlign = HorizontalAlignment.Right;
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();
                    break;
                case Keys.F3:
                    cbProcurar.SelectedIndex = 1;
                    txtPesquisa.TextAlign = HorizontalAlignment.Left;
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();
                    break;
                case Keys.F4:
                    cbProcurar.SelectedIndex = 2;
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();
                    break;
                case Keys.F5:
                    cbProcurar.SelectedIndex = 3;
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();
                    break;

                case Keys.Enter:
                 
                        this.ProcessTabKey(true);
                        e.SuppressKeyPress = true;
                        e.Handled = true;                   
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        private void frmPesquisa_Load(object sender, EventArgs e)
        {
            cbProcurar.SelectedIndex = 0;
        }

        // Selecionando na cbo
        private void cbProcurar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbProcurar.SelectedIndex)
            {
                case 0:
                    cbProcurar.SelectedIndex = 0;
                    txtPesquisa.Visible = true;
                    txtPesquisa.TextAlign = HorizontalAlignment.Right;
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();
                    break;
                case 1:
                    cbProcurar.SelectedIndex = 1;
                    txtPesquisa.TextAlign = HorizontalAlignment.Left;
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();
                    break;
                case 2:
                    cbProcurar.SelectedIndex = 2;
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();
                    break;
                case 3:
                    cbProcurar.SelectedIndex = 3;
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();
                    break;                
            }
        }
    }
}
