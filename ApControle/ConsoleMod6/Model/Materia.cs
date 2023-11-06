using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMod6.Model
{
    public class Materia : BaseModel
    {
        public int CodMateria { get; set; }
        public string NomeMateria { get; set; }
        public string Ementa { get; set; }
    }
}
