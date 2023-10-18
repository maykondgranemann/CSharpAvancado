using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.POO
{
    internal class Cachorro : Animal
    {
        public string Raca { get; set; }

        public Cachorro()
        {
            
        }
        public Cachorro(string nome) : base(nome)
        {
 
        }

        // Reescrever -  Substituido a funcionalidade da classe mãe
        public override void Comer()
        {
            Console.Write($"Cachorro {this.Nome}");
            base.Comer();
            // a classe mae ou seja Animal
        }

        public override string ToString()
        {
            return base.ToString() + $"{this.Raca};";
        }
    }
}
