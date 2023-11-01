using EscolaModulo5.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaModulo5.Controller
{
    internal class ControlerAluno : IController
    {
        public void Create(Aluno model)
        {
            StreamWriter _writer = new StreamWriter("C:\\BancoDeDados\\Aluno.txt", true);
            //converto o objeto aluno em String para salvar na linha do TXT
            string linha = model.ToString();
            try
            {
                //escrevento a linha no TXT
                _writer.WriteLine(linha);
                //Fechando o arquivo TXT
                _writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> Read()
        {
            StreamReader _reader = new StreamReader("C:\\BancoDeDados\\Aluno.txt");
            List<Aluno> alunos = new List<Aluno>();

            string linha = _reader.ReadLine();

            while (linha != null)
            {
                var aluno = linha.Split(';');
                Aluno model = new Aluno { Id = Convert.ToInt32(aluno[0]), Matricula = aluno[1], Nome = aluno[2], Sobrenome = aluno[3] };
                alunos.Add(model);
                linha = _reader.ReadLine();
            }
            _reader.Close();
            return alunos;
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
