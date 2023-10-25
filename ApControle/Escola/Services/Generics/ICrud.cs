using Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Services.Generics
{
    internal interface ICrud<T> where T : BaseModel
    {
        void Create(T model);
        // Sobrecarga de metodos
        List<T> Read();
        T Read(int id);
        void Update(T model);
        void Delete(int id);
    }
}
