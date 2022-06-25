using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using controle_de_pedidos.Entidades;
using System.Data;

namespace controle_de_pedidos.DAL
{
    public class ClientesDAL : Conexao
    {
        SqlCommand comando = null;

        public void Salvar(Cliente cliente)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("INSERT INTO Clientes (ClieNome, ClieEndereco, ClieCep, ClieCidade, ClieEstado, ClieDataCadastro)" +
                                           " VALUES (@ClieNome, @ClieEndereco, @ClieCep, @ClieCidade, @ClieEstado, @ClieDataCadastro)", conexao);

                comando.Parameters.AddWithValue("@ClieNome", cliente.ClieNome);
                comando.Parameters.AddWithValue("@ClieEndereco", cliente.ClieEndereco);
                comando.Parameters.AddWithValue("@ClieCep", cliente.ClieCep);
                comando.Parameters.AddWithValue("@ClieCidade", cliente.ClieCidade);
                comando.Parameters.AddWithValue("@ClieEstado", cliente.ClieEstado);
                comando.Parameters.AddWithValue("@ClieDataCadastro", cliente.ClieDataCadastro.ToString("dd/MM/yyyy"));

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

        public void Editar(Cliente cliente)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("UPDATE Clientes SET ClieNome =" +
                    " @ClieNome, ClieEndereco = @ClieEndereco, ClieCep = @ClieCep, ClieCidade = @ClieCidade, ClieEstado = @ClieEstado WHERE ClieCodigo = @ClieCodigo ", conexao);

                comando.Parameters.AddWithValue("@ClieCodigo", cliente.ClieCodigo);
                comando.Parameters.AddWithValue("@ClieNome", cliente.ClieNome);
                comando.Parameters.AddWithValue("@ClieEndereco", cliente.ClieEndereco);
                comando.Parameters.AddWithValue("@ClieCep", cliente.ClieCep);
                comando.Parameters.AddWithValue("@ClieEstado", cliente.ClieEstado);
                comando.Parameters.AddWithValue("@ClieCidade", cliente.ClieCidade);

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

        public void Excluir(Cliente cliente)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("DELETE FROM Clientes WHERE ClieCodigo = @ClieCodigo", conexao);

                comando.Parameters.AddWithValue("@ClieCodigo", cliente.ClieCodigo);

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

        public Cliente Pesquisar(int ID)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                AbrirConexao();
                if (ID == 0)
                {
                    sb.Append("SELECT TOP 1 (ClieCodigo) AS Ultimo, * ")
                      .Append("FROM Clientes ")
                      .Append("ORDER BY Ultimo DESC");
                }
                else
                {
                    sb.Append("SELECT * FROM Clientes WHERE ClieCodigo=" + ID);
                }
                SqlDataReader dr = new SqlCommand(sb.ToString(), conexao).ExecuteReader();
                Cliente cliente = new Cliente();
                while (dr.Read())
                    cliente = CarregaObj(dr);
                return cliente;
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

        public List<Cliente> CarregaGrid(string Where)
        {
            try
            {
                AbrirConexao();

                List<Cliente> listaClientes = new List<Cliente>();

                comando = new SqlCommand("SELECT * FROM Clientes " + Where, conexao);
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente = CarregaObj(dr);
                    listaClientes.Add(cliente);
                }
                return listaClientes;
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
        // 
        public Cliente CarregaObj(SqlDataReader dr)
        {
            Cliente cliente = new Cliente();

            if (dr["ClieCodigo"] != DBNull.Value)
                cliente.ClieCodigo = Convert.ToInt32(dr["ClieCodigo"]);

            if (dr["ClieNome"] != DBNull.Value)
                cliente.ClieNome = dr["clieNome"].ToString();

            if (dr["ClieEndereco"] != DBNull.Value)
                cliente.ClieEndereco = dr["clieEndereco"].ToString();

            if (dr["ClieCep"] != DBNull.Value)
                cliente.ClieCep = dr["clieCep"].ToString();

            if (dr["ClieCidade"] != DBNull.Value)
                cliente.ClieCidade = dr["clieCidade"].ToString();

            if (dr["ClieEstado"] != DBNull.Value)
                cliente.ClieEstado = dr["clieEstado"].ToString();

            if (dr["ClieDataCadastro"] != DBNull.Value)
                cliente.ClieDataCadastro = DateTime.Parse(dr["clieDataCadastro"].ToString());

            return cliente;
        }

        public int Primeiro()
        {
            AbrirConexao();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT MIN(ClieCodigo) AS Primeiro ")
               .Append("FROM Clientes ")
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
            sb.Append("SELECT MIN(ClieCodigo) AS Proximo ")
               .Append("FROM Clientes ")
               .Append("WHERE ClieCodigo > @ClieCodigo ")
                .Append("ORDER BY Proximo DESC");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conexao);
            cmd.Parameters.AddWithValue("@ClieCodigo", codigoAtual);

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
            sb.Append("SELECT MAX(ClieCodigo) AS Anterior ")
               .Append("FROM Clientes ")
               .Append("WHERE ClieCodigo < @ClieCodigo ")
                .Append("ORDER BY Anterior DESC");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conexao);
            cmd.Parameters.AddWithValue("@ClieCodigo", codigoAtual);

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
            sb.Append("SELECT MAX(ClieCodigo) AS Ultimo ")
               .Append("FROM Clientes ")
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
