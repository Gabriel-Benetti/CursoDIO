using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializacao.Models
{
    internal class Vendas
    {
        public Vendas()
        {
            
        }

        public Vendas(int id, string produto, decimal valor)
        {
            Id = id;
            Produto = produto;
            Valor = valor;

            
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public Decimal Valor { get; set; }
    }
}
