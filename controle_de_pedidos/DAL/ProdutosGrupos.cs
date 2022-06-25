using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_pedidos.DAL
{
	public class ProdutosGrupos
	{
		public int Incluir(Entidades.ProdutosGrupos produtosgrupos)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("INSERT INTO ProdutosGrupos (GrupDescricao) ")
			   .Append("VALUES (@GrupDescricao) SELECT @@identity");

			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
				cmd.Parameters.AddWithValue(@"GrupDescricao", produtosgrupos.GrupDescricao);
				try
				{
					conn.Open();
					return Convert.ToInt32(cmd.ExecuteScalar());
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

		public int Alterar(Entidades.ProdutosGrupos produtosgrupos)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("UPDATE ProdutosGrupos SET GrupDescricao = @GrupDescricao ")
			   .Append("WHERE GrupID = @GrupID");
			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
				cmd.Parameters.AddWithValue(@"GrupID", produtosgrupos.GrupID);
				cmd.Parameters.AddWithValue(@"GrupDescricao", produtosgrupos.GrupDescricao);
				try
				{
					conn.Open();
					return cmd.ExecuteNonQuery();
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

		public int Excluir(int ID)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("DELETE FROM ProdutosGrupos ")
			   .Append("WHERE GrupID = @GrupID");
			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
				cmd.Parameters.AddWithValue("@GrupID", ID);
				try
				{
					conn.Open();
					return cmd.ExecuteNonQuery();
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

		public Entidades.ProdutosGrupos PesquisarRegistroAposExclusao(int ID)
		{
			bool bolEncontrou = false;
			Entidades.ProdutosGrupos produtosgrupos = null;
			StringBuilder sb = new StringBuilder();
			sb.Append("SELECT TOP 1 (GrupID) AS Ultimo, * ")
			   .Append("FROM ProdutosGrupos ")
			   .Append("WHERE GrupID < @GrupID ")
			   .Append("ORDER BY Ultimo DESC");

			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
				cmd.Parameters.AddWithValue("@GrupID", ID);
				try
				{
					conn.Open();
					SqlDataReader dr = cmd.ExecuteReader();
					while (dr.Read())
					{
						produtosgrupos = CarregarObj(dr);

						bolEncontrou = true;
					}

					if (bolEncontrou) return produtosgrupos;

					dr.Close();

					sb.Clear();

				    sb.Append("SELECT TOP 1(GrupID) AS Ultimo, * ")
					.Append("FROM ProdutosGrupos ")
					.Append("WHERE GrupID > @GrupID ")
					 .Append("ORDER BY Ultimo ASC");
					cmd = new SqlCommand(sb.ToString(), conn);
					cmd.Parameters.AddWithValue("@GrupID", ID);

					dr = cmd.ExecuteReader();
					while (dr.Read())
					{
						produtosgrupos = CarregarObj(dr);
					}
					return produtosgrupos;
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

		public Entidades.ProdutosGrupos Pesquisar(int ID)
		{
			Entidades.ProdutosGrupos produtosgrupos = null;
			StringBuilder sb = new StringBuilder();
			if (ID == 0)
				sb.Append("SELECT TOP 1(GrupID) AS Ultimo,* ")
				   .Append("FROM ProdutosGrupos  ")
				   .Append("ORDER BY Ultimo DESC");
			else
				sb.Append("SELECT * FROM ProdutosGrupos ")
				  .Append("WHERE GrupID = @GrupID");

			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
				cmd.Parameters.AddWithValue(@"GrupID", ID);
				try
				{
					conn.Open();
					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						produtosgrupos = CarregarObj(dr);

						return produtosgrupos;
					}

					return produtosgrupos;
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

		public List<Entidades.ProdutosGrupos> CarregarGrid(string strWhere)
		{
			Entidades.ProdutosGrupos produtosgrupos = null;
			if (!string.IsNullOrEmpty(strWhere))
				strWhere = "WHERE " + strWhere;

			StringBuilder sb = new StringBuilder();
			sb.Append("SELECT * FROM ProdutosGrupos ")
			   .Append(" " + strWhere + " ")
			   .Append("ORDER BY GrupID ");

			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				List<Entidades.ProdutosGrupos> listaProdutosGrupos = new List<Entidades.ProdutosGrupos>();
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

				try
				{
					conn.Open();
					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						produtosgrupos = CarregarObj(dr);
						listaProdutosGrupos.Add(produtosgrupos);
					}

					return listaProdutosGrupos;
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

		public Entidades.ProdutosGrupos CarregarObj(SqlDataReader dr)
		{
			Entidades.ProdutosGrupos produtosgrupos = new Entidades.ProdutosGrupos();

			if (dr["GrupID"] != DBNull.Value)
				produtosgrupos.GrupID = Convert.ToInt32(dr["GrupID"]);

			if (dr["GrupDescricao"] != DBNull.Value)
				produtosgrupos.GrupDescricao = dr["GrupDescricao"].ToString();

			return produtosgrupos;
		}

		public int Primeiro()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("SELECT MIN(GrupID) AS Primeiro ")
			   .Append("FROM ProdutosGrupos ")
			   .Append("ORDER BY Primeiro DESC");
			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

				try
				{
					int codigo = 0;
					conn.Open();
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
			}
		}

		public int Proximo(int codigoAtual)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("SELECT MIN(GrupID) AS Proximo ")
			   .Append("FROM ProdutosGrupos ")
			   .Append("WHERE GrupID > @GrupID ")
				.Append("ORDER BY Proximo DESC");

			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
				cmd.Parameters.AddWithValue("@GrupID", codigoAtual);

				try
				{
					int codigo = 0;
					conn.Open();
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
			}

		}

		public int Anterior(int codigoAtual)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("SELECT MAX(GrupID) AS Anterior ")
			   .Append("FROM ProdutosGrupos ")
			   .Append("WHERE GrupID < @GrupID ")
				.Append("ORDER BY Anterior DESC");

			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
				cmd.Parameters.AddWithValue("@GrupID", codigoAtual);

				try
				{
					int codigo = 0;
					conn.Open();
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
			}
		}

		public int Ultimo()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("SELECT MAX(GrupID) AS Ultimo ")
			   .Append("FROM ProdutosGrupos ")
			   .Append("ORDER BY Ultimo DESC");

			using (SqlConnection conn = new DAL.Conexao().GetConnection())
			{
				SqlCommand cmd = new SqlCommand(sb.ToString(), conn);

				try
				{
					int codigo = 0;
					conn.Open();
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
			}
		}

	}
}
