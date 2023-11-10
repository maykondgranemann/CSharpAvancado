using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApControle.Data
{
    public abstract class BaseModel
    {
        public int Id { get; set; }

        public override string ToString()
        {
            return $"{this.Id}";
        }
    }
}
