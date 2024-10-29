using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleVendas.model
{
    internal class Produto
    {
        public int Id { get; set; } 
        public string Descricao { get; set; }
        public Decimal Preco {  get; set; }
        public int QtdEstoque { get; set; }
        public fornecedor Fornecedor { get; set; }


    }
}
