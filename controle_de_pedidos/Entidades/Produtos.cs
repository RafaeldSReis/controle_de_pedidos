using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_pedidos.Entidades
{
    
    public class Produtos
    {

        public int ProdCodigo { get; set; }
        public string prodDescricao { get; set; }
        public string prodUnidade { get; set; }
        public double prodValorCompra { get; set; }
        public double prodValorVenda { get; set; }

        public ProdutosGrupos ProdutosGrupos { get; set; }

        public Produtos(){
            this.ProdutosGrupos = new ProdutosGrupos();
        }

        public Produtos(int prodCodigo, string prodDescricao, string prodUnidade, double prodValorCompra, double prodValorVenda)
        {
            ProdCodigo = prodCodigo;
            this.prodDescricao = prodDescricao;
            this.prodUnidade = prodUnidade;
            this.prodValorCompra = prodValorCompra;
            this.prodValorVenda = prodValorVenda;
            this.ProdutosGrupos = new ProdutosGrupos();
        }


    }
}
