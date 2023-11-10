using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApControle.Data
{
    public abstract class Pessoa : BaseModel
    {
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public override string ToString()
        {
            return base.ToString() + $";{this.Matricula};{this.Nome};{this.Sobrenome}";
        }
    }
}
