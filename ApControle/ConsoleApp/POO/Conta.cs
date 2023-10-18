using ConsoleApp.Tipos._1_Referencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.POO
{
    //A palavra chave ABSTRACT Nao deixa criar um objeto
    internal abstract class Conta
    {
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        //Composição
        public Pessoa Titular { get; set; }


        public virtual void Depositar(decimal valor)
        {
            this.Saldo += valor;
        }
        public virtual decimal Sacar(decimal valor)
        {
            this.Saldo -= valor;
            return this.Saldo;
        }
    }
}
