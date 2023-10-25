using Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Services
{
    internal interface ICrudAluno
    {            

        void Create(Aluno model);
        // Sobrecarga de metodos
        List<Aluno> Read();
        Aluno Read(int id);
        void Update(Aluno model);
        void Delete(int id);
    }
}
