using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tipos._0_Valor
{
    internal struct Conta
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public decimal Saldo { get; set; }


        public decimal Deposita(decimal valor)
        {
            this.Saldo += valor;
            return this.Saldo;
        }
    }
}
