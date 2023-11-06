using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMod6.Model
{
    public class Aluno : BaseModel
    {
        public string Nome { get; set; }
        public byte Idade { get; set; }
        public string Matricula { get; set; }

        public Endereco Endereco { get; set; }
    }
}
