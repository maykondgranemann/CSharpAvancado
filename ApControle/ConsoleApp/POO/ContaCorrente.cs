using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.POO
{
    internal class ContaCorrente : Conta
    {

        public ContaCorrente(decimal depositoInicial)
        {
            this.Depositar(depositoInicial);
        }
        private int _numSaques;
        public override decimal Sacar(decimal valor)
        {
            this._numSaques++;
            if(this._numSaques == 10)
            {
                this.Saldo -= 0.25M;
                this._numSaques = 0;
            }
            return base.Sacar(valor);
        }
    }
}
