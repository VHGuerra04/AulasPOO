using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Item
    {
        public int codigo_item { get; set; }
        public string descricao { get; set; }
        public string autor { get; set; }
        public int ano { get; set; }
        public string editora { get; set; }
        public int edicao { get; set; }
        public int idioma { get; set; }
        public int tipo { get; set; }
        public string situacao { get; set; }

        public bool Cadastrar(Item objItem)
        {
            return true;
        }

        public string BuscarNome(Item objItem)
        {
            return objItem.descricao;
        }

    }

}
