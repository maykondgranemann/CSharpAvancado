﻿// See https://aka.ms/new-console-template for more information


using ConsoleApp.POO;
using ConsoleApp.Tipos._0_Valor;
using ConsoleApp.Tipos._1_Referencia;

//Console.WriteLine("Hello, World!");

//Inteiros inteiros = new Inteiros();
//inteiros.Exec();

//Flutuante flutuante = new Flutuante();
//flutuante.Executar();

//Delegates delegates = new Delegates();
//delegates.Executa();


//Enumeradores enumeradores   = new Enumeradores();
//enumeradores.Executa();


//Conta conta = new Conta();  
//conta.Id = 1;
//conta.NomeCompleto = "Maykon Granemann";
//conta.Saldo = 15.5m;
//decimal saldoTotal = conta.Deposita(30);
//Console.WriteLine(saldoTotal);

//Conta conta2 = conta;
//conta2.Deposita(30);
//Console.WriteLine(conta2.Saldo);

//Console.WriteLine(conta.Saldo);




//ContaClasse contaClasse = new ContaClasse();
//contaClasse.Id = 1;
//contaClasse.NomeCompleto = "Maykon Granemann";
//contaClasse.Saldo = 15.5m;
//decimal saldoTotalClasse = contaClasse.Deposita(30);
//Console.WriteLine(saldoTotalClasse);

//ContaClasse conta2Classe = contaClasse;
//conta2Classe.Deposita(30);
//Console.WriteLine(conta2Classe.Saldo);

//Console.WriteLine(contaClasse.Saldo);


//Pessoa pessoa = new Pessoa();
//pessoa.Nome = "Maykon";
//pessoa.Idade = 10;
//Console.WriteLine(pessoa);

//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Maykon";
//pessoa1.Idade = 20;
//Console.WriteLine(pessoa1);

//Pessoa pessoa2 = pessoa;


//Console.WriteLine(pessoa.Equals(pessoa1));

//Animal animal1 = new Animal();
//Animal animal2 = new Animal();

//Cachorro cachorro = new Cachorro();
//cachorro.Nome = "Nick";
//cachorro.Raca = "Vira-lata";
//cachorro.Comer();
//Console.WriteLine(cachorro);

//Animal animal3 = new Cachorro();
//animal3.Comer();

//Cachorro cachorro2 = new Cachorro();
//cachorro2.Nome = "Totó";
//cachorro2.Raca = "Tomba";
//Console.WriteLine(cachorro2);

//Animal animal4 = cachorro2;

//Console.WriteLine(animal4); 




using ConsoleApp.POO;

ContaCorrente cc1 = new ContaCorrente(100);
decimal saldo = cc1.Sacar(10);
Console.WriteLine(saldo);

ContaPoupanca cp1 = new ContaPoupanca();
saldo = cp1.Sacar(10);
Console.WriteLine(saldo);



