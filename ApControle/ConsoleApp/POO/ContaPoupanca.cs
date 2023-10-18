using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.POO
{
    internal class ContaPoupanca : Conta
    {
        public override decimal Sacar(decimal valor)
        {
            // taxa de saque para poupanca
            this.Saldo -= 0.1M;
            return base.Sacar(valor);
        }
    }
}
