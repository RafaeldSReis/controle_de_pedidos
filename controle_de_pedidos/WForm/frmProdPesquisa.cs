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
    public partial class frmProdPesquisa : Form
    {

        public frmProdPesquisa FrmProdPesquisa = null;
        public int Resultado { get; set; }
        public frmProdPesquisa()
        {
            InitializeComponent();
            txtPesquisa.Focus();
        }

        private void btnVolta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Busca uma lista de Produtos no banco de dados
        private void CarregaGrid(List<Produtos> lstProdutos)
        {
            try
            {
                dgvPesquisa.AutoGenerateColumns = false;
                dgvPesquisa.DataSource = lstProdutos;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string strWhere = "";
            if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                switch (cbProcurar.SelectedIndex)
                {
                    case 0:
                        strWhere = (" WHERE p.ID=" + txtPesquisa.Text);
                        break;
                    case 1:
                        strWhere = (" WHERE p.ProdDescricao LIKE '%" + txtPesquisa.Text + "%'");
                        break;
                }
                CarregaGrid(new ProdutosBLL().CarregaGrid(strWhere));
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
               
        private void frmProdPesquisa_Load(object sender, EventArgs e)
        {
            cbProcurar.SelectedIndex = 0;
        }

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
                    txtPesquisa.Visible = true;
                    txtPesquisa.TextAlign = HorizontalAlignment.Right;
                    txtPesquisa.Text = "";
                    txtPesquisa.Focus();
                    break;               
            }
        }
       
    }
}
