using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.POO
{
    // Uma interface diz o que deve ser feito mas não o como deve ser feito
    internal interface Crud
    {
        int Id { get; set; }

        void Create(Object model);
        List<Object> GetAll();
        Object Get(int id);
        void Update(Object model);
        void Delete(int id);
    }
}
