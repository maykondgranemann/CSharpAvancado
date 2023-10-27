// See https://aka.ms/new-console-template for more information
using Escola.Models;
using Escola.Services;

Console.WriteLine("Bem-vindo, Escola!");

Aluno aluno1 = new Aluno();
aluno1.Id = 1;
aluno1.Matricula = "A12";
aluno1.Nome = "Maykon";
aluno1.Sobrenome = "Granemann";

CrudAluno alunoCrud = new CrudAluno();
alunoCrud.Create(aluno1);

foreach (var aluno in alunoCrud.Read())
{
    Console.WriteLine(aluno);
}