using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_pedidos.Entidades
{
    public class Cliente
    {
        int clieCodigo;
        string clieNome;       
        string clieEndereco;
        string clieCep;
        string clieCidade;
        string clieEstado; 

        public DateTime ClieDataCadastro { get; set; }
        public string ClieNome { get => clieNome; set => clieNome = value; }
        public string ClieCep { get => clieCep; set => clieCep = value; }
        public string ClieEndereco { get => clieEndereco; set => clieEndereco = value; }
        public string ClieCidade { get => clieCidade; set => clieCidade = value; }
        public int ClieCodigo { get => clieCodigo; set => clieCodigo = value; }
        public string ClieEstado { get => clieEstado; set => clieEstado = value; }
        
    }
}
