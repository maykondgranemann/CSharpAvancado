using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tipos._1_Referencia
{
    internal class Pessoa
    {
        //Encapsulamento
        // Exemplo de Getter e Setter como no Java
        //private int id;
        //private string nome;
        //private string sobrenome;

        //public int GetId()
        //{
        //    return id;
        //}
        //public void SetId(int id)
        //{
        //    if(id>0)
        //        this.id = id;
        //}

        // Como é no C# getter e setters em uma Propriedade
        private static int _id = 0;
        public int Id { get; private set; }
        
        private int _idade;
        public int Idade 
        {
            get
            {
                return _idade;
            }            
            set
            {
                if(value > 0)
                {
                    this._idade = value;
                }
            } 
        }
        public string Nome { get; set; }

        public Pessoa()
        {
            this.GeraId();
        }
        public Pessoa(string nome)
        {
            this.Nome = nome;
            this.GeraId();
        }
        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.GeraId();
        }
        private void GeraId()
        {
            this.Id = ++_id;           
        }
        // Toda classe do C# herda por padrao da classe Object
        public override string ToString()
        {
            return $"{this.Id} {this.Idade} {this.Nome}";
        }
        //Comparacao de objetos ou seja se um objeto pessoa é igual a esta pessoa em questao;
        public override bool Equals(object? obj)
        {
            //Pessoa objeto = (Pessoa)obj;
            Pessoa objeto = obj as Pessoa;

            if (objeto.Nome == this.Nome)
                return true;
            return false;
        }
    }
}
