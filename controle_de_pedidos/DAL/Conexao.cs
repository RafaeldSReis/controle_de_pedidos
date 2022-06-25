using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace controle_de_pedidos.DAL
{
    public class Conexao
    {

         //string conectar = @"Server=PROGRAMACAO05\DADOS;Database=BDRAFAEL2;Uid=sa;Pwd=oficina@1778;";

       string conectar = @"Server=.;Database=controle_de_pedidos;Uid=sa;Pwd=senac;";
        protected SqlConnection conexao = null;


        public void AbrirConexao()
        {
            try
            {
                conexao = new SqlConnection(conectar);
                conexao.Open();
            }
            catch (Exception erro)
            {

                throw erro;
            }

        }



        public SqlConnection GetConnection()
        {
            try
            {

                
                return new SqlConnection(conectar);
            }
            catch (Exception erro)
            {

                throw erro;
            }

        }

        public void FecharConexao()
        {
            try
            {
                conexao = new SqlConnection(conectar);
                conexao.Close();
            }
            catch (Exception erro)
            {

                throw erro;
            }

        }

    }
}
