using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Cliente
    {
        public int Codigo { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set;}
        public int Idade  { get; set;}

        //Método Construtor
        public Cliente(string CPF, string Nome)
        {
            this.CPF = CPF;
            this.Nome = Nome;
        }

        public Cliente(string CPF)
        {
            this.CPF = CPF;
        }

        public bool MaiorDeIdade(int IdadeMinima)
        {
            if (this.Idade > IdadeMinima)
                return true;
            else
                return false;
        }
    }
}
