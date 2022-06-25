using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_pedidos.Entidades
{
	public class ProdutosGrupos
	{
		public ProdutosGrupos()
		{
			GrupDescricao = string.Empty;
		}
		public int GrupID { get; set; }

		public string GrupDescricao { get; set; }

	}
}