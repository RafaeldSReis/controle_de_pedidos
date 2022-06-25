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
    public class ClientesBLL : Cliente
    {
        ClientesDAL clientesDAL = new ClientesDAL();

        public void Salvar(Cliente cliente)
        {
            try
            {
                clientesDAL.Salvar(cliente);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        public void Editar(Cliente cliente)
        {
            try
            {
                clientesDAL.Editar(cliente);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        public void Excluir(Cliente cliente)
        {
            try
            {
                clientesDAL.Excluir(cliente);
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERRO" + ex.Message);
            }
        }

        public List<Cliente> CarregaGrid(string Where)
        {
            try
            {          
                return new ClientesDAL().CarregaGrid(Where); ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente Pesquisar(int ID)
        {
            try
            {
               
                return new ClientesDAL().Pesquisar(ID);
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
                return new ClientesDAL().Primeiro();
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
                return new ClientesDAL().Proximo(codigoAtual);
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
                return new ClientesDAL().Anterior(codigoAtual);
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
                return new ClientesDAL().Ultimo();
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
