using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Pessoa
    {
        //Atributos
        public int codigo_pessoa {  get; set; }

        public string nome { get; set; }
        public string CPF { get; set; }
        public string Genero { get; set; }
        public string DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        //Métodos
       
        public bool Cadastrar(Pessoa objPessoa)
        
        {
            //Aqui iria o código que salva a pessoa no BD
            return true;
   
        }

        public string BuscarNome(Pessoa objPessoa)
        {
            return objPessoa.nome;
        }

    }
}
