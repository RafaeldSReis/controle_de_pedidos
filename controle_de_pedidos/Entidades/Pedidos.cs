using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_pedidos.Entidades
{
    public class Pedidos
    {
        public int PediID { get; set; }
        public string PediObservacao { get; set; }
        public double PediValorTotal { get; set; }
        public int PediCliente { get; set; }
        public DateTime PediData { get; set; }      
    }

}
