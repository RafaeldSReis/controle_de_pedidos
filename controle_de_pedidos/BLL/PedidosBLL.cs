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
    public class PedidosBLL
    {
        PedidosDAL PedidosDAL = new PedidosDAL();

        public void Salvar(Pedidos pedidos)
        {
            try
            {
                PedidosDAL.Salvar(pedidos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        public void Editar(Pedidos pedidos)
        {
            try
            {
                PedidosDAL.Editar(pedidos);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        public void Excluir(Pedidos pedidos)
        {
            try
            {
                PedidosDAL.Excluir(pedidos);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        public List<Pedidos> CarregaGrid(string Where)
        {
            try
            {
                return new PedidosDAL().CarregaGrid(Where); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Pedidos Pesquisar(int ID)
        {
            try
            {

                return new PedidosDAL().Pesquisar(ID);
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
                return new PedidosDAL().Primeiro();
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
                return new PedidosDAL().Proximo(codigoAtual);
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
                return new PedidosDAL().Anterior(codigoAtual);
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
                return new PedidosDAL().Ultimo();
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
