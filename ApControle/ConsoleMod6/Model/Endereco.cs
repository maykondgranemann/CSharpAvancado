using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMod6.Model
{
    public class Endereco : BaseModel
    {
        // somente dados pertinentes ao dominio, endereco é outro dominio
        // quando tenho muitos dados relacionados  e que podem ser utilizados por outros (reaproveitamento)
        // e que podem ser modificados, acrescentado ou removido campos, (manutencao)
        // entao posso extrair para outro dominio
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Completo { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}
