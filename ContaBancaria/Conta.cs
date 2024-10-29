using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Conta
    {
        public int Numero {  get; set; }
        public string Agencia { get; set; }

        //Publico para buscar e privado para salvar
        //atributo saldo inicial com valor 100 reais
        public double Saldo { get; set; } = 100;
        //Composição da classe
        public Cliente Titular { get; set; }
        //Métodos
        public bool Sacar(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
                
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }
        




    }
}
