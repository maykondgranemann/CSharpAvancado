using Escola.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.Services
{
    public class CrudAluno : ICrudAluno
    {
        public void Create(Aluno model)
        {
            string linha;
            try
            {
                StreamWriter sw = new StreamWriter("Aluno.txt", true);
                sw.WriteLine(model);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> Read()
        {            
            List<Aluno> lista = new List<Aluno>();
            string linha;
            try
            {

                StreamReader sr = new StreamReader("Aluno.txt");                
                linha = sr.ReadLine();
                while (linha != null)
                {
                    var aluno =  linha.Split(';');
                    Aluno model = new Aluno{ Id = Convert.ToInt32(aluno[0]), Matricula = aluno[1], Nome = aluno[2], Sobrenome = aluno[3] };
                    lista.Add(model);
                    linha = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return lista;
        }

        public Aluno Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Aluno model)
        {
            throw new NotImplementedException();
        }
    }
}
