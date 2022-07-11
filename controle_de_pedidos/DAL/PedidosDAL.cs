using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;
using controle_de_pedidos.Entidades;

namespace controle_de_pedidos.DAL
{
    public class PedidosDAL : Conexao
    {
        SqlCommand comando = null;

        public void Salvar(Pedidos pedidos)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("INSERT INTO Pedidos ( PediData, PediObservacao, PediValorTotal, PediCliente)" +
                                           " VALUES (@PediData, @PediObservacao, @PediValorTotal, @PediCliente )", conexao);
               
                comando.Parameters.AddWithValue("@PediObservacao", pedidos.PediObservacao);
                comando.Parameters.AddWithValue("@PediValorTotal", pedidos.PediValorTotal);
                comando.Parameters.AddWithValue("@PediCliente", pedidos.PediCliente);               
                comando.Parameters.AddWithValue("@PediData", pedidos.PediData.ToString("dd/MM/yyyy"));
                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }


        public void Editar(Pedidos pedidos)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("UPDATE Pedidos SET PediObservacao =" +
                    " @PediObservacao, PediValorTotal = @PediValorTotal, PediCliente = @PediCliente WHERE PediID = @PediID ", conexao);

                comando.Parameters.AddWithValue("@PediID", pedidos.PediID);
                comando.Parameters.AddWithValue("@PediObservacao", pedidos.PediObservacao);
                comando.Parameters.AddWithValue("@PediValorTotal", pedidos.PediValorTotal);
                comando.Parameters.AddWithValue("@PediCliente", pedidos.PediCliente);                

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public void Excluir(Pedidos pedidos)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("DELETE FROM Pedidos WHERE PediID = @PediID", conexao);

                comando.Parameters.AddWithValue("@PediID", pedidos.PediID);

                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        public Pedidos Pesquisar(int ID)
        {
            StringBuilder sb = new StringBuilder();

            try
            {               
                AbrirConexao();
                if (ID == 0)
                {
                    sb.Append("SELECT TOP 1 (PediID) AS Ultimo, * ")
                      .Append("FROM Pedidos ")
                      .Append("ORDER BY Ultimo DESC");
                }
                else
                {
                    sb.Append("SELECT * FROM Pedidos WHERE PediID=" + ID);
                }
                SqlDataReader dr = new SqlCommand(sb.ToString(), conexao).ExecuteReader();
                Pedidos pedidos = new Pedidos();
                while (dr.Read())
                    pedidos = CarregaObj(dr);
                return pedidos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<Pedidos> CarregaGrid(string Where)
        {
            try
            {
                AbrirConexao();

                List<Pedidos> listaPedidos = new List<Pedidos>();

                comando = new SqlCommand("SELECT * FROM Pedidos " + Where, conexao);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Pedidos pedidos = new Pedidos();
                    pedidos = CarregaObj(dr);
                    listaPedidos.Add(pedidos);
                }
                return listaPedidos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }


        public Pedidos CarregaObj(SqlDataReader dr)
        {

            Pedidos pedidos = new Pedidos();

            if (dr["PediID"] != DBNull.Value)
                pedidos.PediID = Convert.ToInt32(dr["PediID"]);

            if (dr["PediObservacao"] != DBNull.Value)
                pedidos.PediObservacao = dr["PediObservacao"].ToString();

            if (dr["PediValorTotal"] != DBNull.Value)
                pedidos.PediValorTotal = double.Parse(dr["PediValorTotal"].ToString());

            if (dr["PediCliente"] != DBNull.Value)
                pedidos.PediCliente = int.Parse(dr["PediCliente"].ToString());

            if (dr["PediData"] != DBNull.Value)
                pedidos.PediData = DateTime.Parse(dr["PediData"].ToString());

            return pedidos;
        }

        public int Primeiro()
        {
            AbrirConexao();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT MIN(PediID) AS Primeiro ")
               .Append("FROM Pedidos ")
               .Append("ORDER BY Primeiro DESC");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conexao);

            try
            {
                int codigo = 0;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["Primeiro"] != DBNull.Value)
                        codigo = Convert.ToInt32(dr["Primeiro"]);
                }

                return codigo;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

        public int Proximo(int codigoAtual)
        {
            AbrirConexao();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT MIN(PediID) AS Proximo ")
               .Append("FROM Pedidos ")
               .Append("WHERE PediID > @PediID ")
                .Append("ORDER BY Proximo DESC");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conexao);
            cmd.Parameters.AddWithValue("@PediID", codigoAtual);

            try
            {
                int codigo = 0;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["Proximo"] != DBNull.Value)
                        codigo = Convert.ToInt32(dr["Proximo"]);
                }
                return codigo;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

        public int Anterior(int codigoAtual)
        {
            AbrirConexao();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT MAX(PediID) AS Anterior ")
               .Append("FROM Pedidos ")
               .Append("WHERE PediID < @PediID ")
                .Append("ORDER BY Anterior DESC");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conexao);
            cmd.Parameters.AddWithValue("@PediID", codigoAtual);

            try
            {
                int codigo = 0;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    if (dr["Anterior"] != DBNull.Value)
                        codigo = Convert.ToInt32(dr["Anterior"]);
                    else
                        codigo = codigoAtual;
                }

                return codigo;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }

        public int Ultimo()
        {
            AbrirConexao();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT MAX(PediID) AS Ultimo ")
               .Append("FROM Pedidos ")
               .Append("ORDER BY Ultimo DESC");
            SqlCommand cmd = new SqlCommand(sb.ToString(), conexao);
            try
            {
                int codigo = 0;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["Ultimo"] != DBNull.Value)
                        codigo = Convert.ToInt32(dr["Ultimo"]);
                }

                return codigo;
            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
