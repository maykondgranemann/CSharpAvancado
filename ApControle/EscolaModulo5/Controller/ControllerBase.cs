using EscolaModulo5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaModulo5.Controller
{
    public class ControllerBase : IController
    {
        private static List<Aluno> _alunos = new List<Aluno>();
        private static int _id = 0;

        public void Create(Aluno model)
        {
            model.Id =  _id++;
            _alunos.Add(model);
        }

        public void Delete(int id)
        {
            _alunos.RemoveAt(id);
        }

        public List<Aluno> Read()
        {
            return _alunos;
        }

        public Aluno Read(int id)
        {
            return _alunos[id];
        }

        public void Update(Aluno model)
        {
            _alunos[model.Id] = model;
        }
    }
}
