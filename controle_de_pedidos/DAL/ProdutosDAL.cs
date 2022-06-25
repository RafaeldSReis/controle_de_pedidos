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
    public class ProdutosDAL : Conexao
    {
        SqlCommand comando = null;

        public void Salvar(Produtos produtos)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("INSERT INTO Produtos (ProdDescricao, ProdUnidade, ProdValorCompra, ProdValorVenda, ProdGpCodigo)" +
                                           " VALUES (@ProdDescricao, @ProdUnidade, @ProdValorCompra, @ProdValorVenda, @GrupID)", conexao);
                comando.Parameters.AddWithValue("@ProdDescricao", produtos.prodDescricao);
                comando.Parameters.AddWithValue("@ProdUnidade", produtos.prodUnidade);
                comando.Parameters.AddWithValue("@ProdValorCompra", produtos.prodValorCompra);
                comando.Parameters.AddWithValue("@ProdValorVenda", produtos.prodValorVenda);
                comando.Parameters.AddWithValue("@GrupID", produtos.ProdutosGrupos.GrupID);               
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


        public void Editar(Produtos produtos)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("UPDATE Produtos SET ProdDescricao =" +
                    " @prodDescricao, ProdUnidade = @ProdUnidade, ProdValorCompra = @ProdValorCompra, ProdValorVenda = @ProdValorVenda, ProdGpCodigo = @ProdGpCodigo WHERE ProdCodigo = @ProdCodigo ", conexao);

                comando.Parameters.AddWithValue("@ProdCodigo", produtos.ProdCodigo);
                comando.Parameters.AddWithValue("@prodDescricao", produtos.prodDescricao);
                comando.Parameters.AddWithValue("@ProdUnidade", produtos.prodUnidade);
                comando.Parameters.AddWithValue("@ProdValorCompra", produtos.prodValorCompra);
                comando.Parameters.AddWithValue("@ProdValorVenda", produtos.prodValorVenda);
                comando.Parameters.AddWithValue("@ProdGpCodigo", produtos.ProdutosGrupos.GrupID);

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

        public void Excluir(Produtos produtos)
        {
            try
            {
                AbrirConexao();

                comando = new SqlCommand("DELETE FROM Produtos WHERE ProdCodigo = @ProdCodigo", conexao);

                comando.Parameters.AddWithValue("@ProdCodigo", produtos.ProdCodigo);

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

        public Produtos Pesquisar(int ID)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                AbrirConexao();
                if (ID == 0)
                {
                    sb.Append("SELECT TOP 1 (ProdCodigo) AS Ultimo, *,pg.*  ")
                      .Append("FROM Produtos AS p ")
                      .Append("INNER JOIN ProdutosGrupos AS pg ON p.ProdGpCodigo = pg.GrupID ")                     
                      .Append("ORDER BY Ultimo DESC");
                }
                else
                {
                    sb.Append("SELECT p.*,pg.* FROM Produtos as p INNER JOIN ProdutosGrupos AS pg ON p.ProdGpCodigo = pg.GrupID WHERE ProdCodigo=" + ID);
                }
                SqlDataReader dr = new SqlCommand(sb.ToString(), conexao).ExecuteReader();
                Produtos produtos = new Produtos();
                while (dr.Read())
                    produtos = CarregaObj(dr);
                return produtos;
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

        public List<Produtos> CarregaGrid(string Where)
        {
            try
            {
                AbrirConexao();                
                List<Produtos> listaProdutos = new List<Produtos>();

                // fazer um JOIN  
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT p.*, pg.* ")
                   .Append("FROM Produtos AS p ")
                   .Append("INNER JOIN ProdutosGrupos AS pg ON p.ProdGpCodigo = pg.GrupID ")
                   .Append(Where);
                SqlCommand cmd = new SqlCommand(sb.ToString(), conexao);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {                          
                    listaProdutos.Add(CarregaObj(dr));
                }
                return listaProdutos;
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
   
       
        public Produtos CarregaObj(SqlDataReader dr)
        {
            
            Produtos produtos = new Produtos();

            if (dr["ProdCodigo"] != DBNull.Value)
                produtos.ProdCodigo = Convert.ToInt32(dr["ProdCodigo"]);

            if (dr["ProdDescricao"] != DBNull.Value)
                produtos.prodDescricao = dr["prodDescricao"].ToString();

            if (dr["ProdUnidade"] != DBNull.Value)
                produtos.prodUnidade = dr["prodUnidade"].ToString();

            if (dr["ProdValorCompra"] != DBNull.Value)
                produtos.prodValorCompra = double.Parse(dr["prodValorCompra"].ToString());

            if (dr["ProdValorVenda"] != DBNull.Value)
                produtos.prodValorVenda = double.Parse(dr["prodValorVenda"].ToString());

            if (dr["GrupID"] != DBNull.Value)
                produtos.ProdutosGrupos.GrupID = int.Parse(dr["GrupID"].ToString());

            if (dr["GrupDescricao"] != DBNull.Value)
                produtos.ProdutosGrupos.GrupDescricao = dr["GrupDescricao"].ToString();

            return produtos;
        }       

        public int Primeiro()
        {
            AbrirConexao();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT MIN(ProdCodigo) AS Primeiro ")
               .Append("FROM Produtos ")
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
            sb.Append("SELECT MIN(ProdCodigo) AS Proximo ")
               .Append("FROM Produtos ")
               .Append("WHERE ProdCodigo > @ProdCodigo ")
                .Append("ORDER BY Proximo DESC");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conexao);
            cmd.Parameters.AddWithValue("@ProdCodigo", codigoAtual);

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
            sb.Append("SELECT MAX(ProdCodigo) AS Anterior ")
               .Append("FROM Produtos ")
               .Append("WHERE ProdCodigo < @ProdCodigo ")
                .Append("ORDER BY Anterior DESC");

            SqlCommand cmd = new SqlCommand(sb.ToString(), conexao);
            cmd.Parameters.AddWithValue("@ProdCodigo", codigoAtual);

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
            sb.Append("SELECT MAX(ProdCodigo) AS Ultimo ")
               .Append("FROM Produtos ")
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
