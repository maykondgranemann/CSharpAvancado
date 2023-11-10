using ApControle.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApControle.Service
{
    public class CrudAluno : ICrudAluno
    {
        private static List<Aluno> _alunos = new List<Aluno>();
        private static int _id = 0;
        public void Create(Aluno model)
        {
            model.Id = ++_id;
            _alunos.Add(model);
        }

        public void Delete(int id)
        {
            _alunos.Remove(this.Read(id));
        }

        public List<Aluno> Read()
        {
            return _alunos;
        }

        public Aluno Read(int id)
        {
            Aluno model = _alunos.First(a=>a.Id == id);
            return model;
        }

        public void Update(Aluno model)
        {
            Aluno antigo = this.Read(model.Id);
            int posicao = _alunos.IndexOf(antigo);
            _alunos[posicao] = model;
        }
    }
}
