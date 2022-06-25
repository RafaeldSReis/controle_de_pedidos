using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using controle_de_pedidos.Entidades;
using controle_de_pedidos.DAL;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace controle_de_pedidos.BLL
{
    public class ProdutosBLL : Produtos
    {
        ProdutosDAL produtosDAL = new ProdutosDAL();

        public void Salvar(Produtos produtos)
        {
            try
            {
               produtosDAL.Salvar(produtos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        public void Editar(Produtos produtos)
        {
            try
            {
                produtosDAL.Editar(produtos);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        public void Excluir(Produtos produtos)
        {
            try
            {
                produtosDAL.Excluir(produtos);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        public List<Produtos> CarregaGrid(string Where)
        {
            try
            {
                return new ProdutosDAL().CarregaGrid(Where); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Produtos Pesquisar(int ID)
        {
            try
            {
                return new ProdutosDAL().Pesquisar(ID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Primeiro()
        {
            try
            {
                return new ProdutosDAL().Primeiro();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Proximo(int codigoAtual)
        {
            try
            {
                return new ProdutosDAL().Proximo(codigoAtual);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Anterior(int codigoAtual)
        {
            try
            {
                return new ProdutosDAL().Anterior(codigoAtual);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Ultimo()
        {
            try
            {
                return new ProdutosDAL().Ultimo();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
