using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Models
{
    public class Turma : BaseModel
    {
        public Professor Professor { get; set; }
        public List<Aluno> Alunos { get; set; }
        public List<Materia> Materias { get; set; }
    }
}
