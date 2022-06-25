using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_pedidos.BLL
{
	public class ProdutosGrupos
	{
		public int Incluir(Entidades.ProdutosGrupos produtosgrupos)
		{
			try
			{
				return new DAL.ProdutosGrupos().Incluir(produtosgrupos);
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

		public int Alterar(Entidades.ProdutosGrupos produtosgrupos)
		{
			try
			{
				return new DAL.ProdutosGrupos().Alterar(produtosgrupos);
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

		public int Excluir(int ID)
		{
			try
			{
				return new DAL.ProdutosGrupos().Excluir(ID);
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

		public Entidades.ProdutosGrupos PesquisarRegistroAposExclusao(int ID)
		{
			try
			{
				return new DAL.ProdutosGrupos().PesquisarRegistroAposExclusao(ID);
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

		public Entidades.ProdutosGrupos Pesquisar(int ID)
		{
			try
			{
				return new DAL.ProdutosGrupos().Pesquisar(ID);
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

		public List<Entidades.ProdutosGrupos> CarregarGrid(string strWhere)
		{
			try
			{
				return new DAL.ProdutosGrupos().CarregarGrid(strWhere);
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

		public int Primeiro()
		{
			try
			{
				return new DAL.ProdutosGrupos().Primeiro();
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
				return new DAL.ProdutosGrupos().Proximo(codigoAtual);
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
				return new DAL.ProdutosGrupos().Anterior(codigoAtual);
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
				return new DAL.ProdutosGrupos().Ultimo();
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