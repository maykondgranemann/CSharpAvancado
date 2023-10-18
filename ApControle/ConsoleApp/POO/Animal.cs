using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.POO
{
    internal class Animal
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string Nome { get; set; }

        public Animal() 
        {
            // this se refere ao objeto que esta sendo usado no momento
            this.Id = ++_id;
        }
        public Animal(string nome)
        {
            this.Nome = nome;
        }

        // a palavra chave VIRTUAL permite que um metodo seja sobreescrito
        public virtual void Comer()
        {
            Console.WriteLine("esta comendo!");
        }

        public override string ToString()
        {
            return $"{this.Id};{this.Nome};";
        }

    }
}
