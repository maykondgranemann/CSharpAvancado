using EscolaModulo5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaModulo5.Controller
{
    internal interface IController
    {
        void Create(Aluno model);
        List<Aluno> Read();
        Aluno Read(int id);
        void Update(Aluno model);
        void Delete(int id);
    }
}
