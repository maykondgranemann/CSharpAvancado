using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Models
{
    public class Professor : Pessoa
    {
        public  List<Materia> Materias { get; set; }
    }
}
