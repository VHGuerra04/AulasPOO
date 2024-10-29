using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class ContaPoupanca : Conta
    {
        public override void Depositar(double valor)
        {
            this.Saldo += valor;
            this.Saldo -= 0.05;     
        }
    }
}
