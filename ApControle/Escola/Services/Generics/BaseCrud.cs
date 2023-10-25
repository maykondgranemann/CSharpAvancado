using Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Services.Generics
{
    //O baseCrud recebe um objeto onde este objeto deve ter uma heranca de Basemodel
    // este objeto denominado B, é enviado para a interface que exige um T, que tambem deve herdar de BaseModel
    public class BaseCrud<B> : ICrud<B> where B : BaseModel
    {
        public void Create(B model)
        {
            Console.WriteLine("Salvando");
        }

        public void Delete(int id)
        {
            Console.WriteLine("Delete");
        }

        public List<B> Read()
        {
            Console.WriteLine("List");
            return new List<B>();
        }

        public B Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(B model)
        {
            Console.WriteLine("Alterando");
        }
    }
}
