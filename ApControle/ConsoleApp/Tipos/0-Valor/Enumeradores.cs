using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tipos._0_Valor
{
    //private acessivel dentro do arquivo 
    // protected acessivel namespace 
    //internal dentro do projeto 
    //public acessivel de qualquer lugar
    //Modificadores de acesso
    internal class Enumeradores
    {
        public void Executa()
        {
            int dias = 62;
            DiasDaSemana diasDaSemana = (DiasDaSemana)dias;

            Console.WriteLine(diasDaSemana);
        }
    }

    [Flags]
    enum DiasDaSemana
    {
        Domingo = 1,
        Segunda = 2,
        Terca = 4,
        Quarta = 8,
        Quinta = 16,
        Sexta = 32,
        Sabado = 64
    }
}

