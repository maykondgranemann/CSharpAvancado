using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMod6.Model
{
    public class Professor : BaseModel
    {
        public string Nome { get; set; }
        public byte Idade { get; set; }
        public string Matricula { get; set; }

        public Endereco Endereco { get; set; }

        // Refatoracao
        public List<Materia> Materias { get; set; }        

    }
}
