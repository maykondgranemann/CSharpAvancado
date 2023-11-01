using EscolaModulo5.Controller;
using EscolaModulo5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaModulo5.View
{
    internal class TelaInicial
    {
        //private ControllerBase _controllerBase = new ControllerBase();
        private ControlerAluno _controllerBase = new ControlerAluno();
        Aluno a1 = new Aluno { Nome="Andre", Sobrenome="Granemann", Matricula="D4" };
        Aluno a2 = new Aluno { Id=0, Nome = "Andre2", Sobrenome = "Granemann2", Matricula = "D8" };

        public void Executa()
        {
            do
            {

           
            Console.WriteLine("Escolha uma das opções: ");
            Console.WriteLine("1-Criar");
            Console.WriteLine("2-Listar");
            Console.WriteLine("2-Listar Por id");
            Console.WriteLine("3-Alterar");
            Console.WriteLine("4-Deletar");
            byte opt = Convert.ToByte(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    _controllerBase.Create(a1);
                    break;
                case 2:
                    var lista = _controllerBase.Read();
                    foreach (var item in lista)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case 3:
                    Console.WriteLine("Digite o id:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var model = _controllerBase.Read(id);
                    Console.WriteLine(model);
                    break;                
                case 4:
                    _controllerBase.Update(a2);
                    break;
                case 5:
                    Console.WriteLine("Digite o id:");
                    int idDelete = Convert.ToInt32(Console.ReadLine());
                    _controllerBase.Delete(idDelete);
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }
            }while (true);
        }
    }
}
