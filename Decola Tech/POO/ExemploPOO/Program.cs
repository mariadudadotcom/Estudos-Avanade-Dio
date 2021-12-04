using System;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface e implementação
            ICalculadora calc = new Calculadora();
            System.Console.WriteLine(calc.Somar(10,12));
            
                     
            // //Classe Object
            // Computador compu = new Computador();
            // System.Console.WriteLine(compu.ToString());

            // //Classe Selada (resolvido)
            // Diretor p3 = new Diretor();
            
            // p3.Nome = "Thiago";
            // p3.Idade = 38;
            // p3.Documento = "33333333";
            // p3.Salario = 2800;

            // p3.Apresentar();

            // //Classe Abstrata
            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();


            //     //Polimorfismo (tempo compilação)
            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("O resultado da primeira soma é: " + calc.Somar(10,12));
            // System.Console.WriteLine("O resultado da segunda soma é: " + calc.Somar(10,12,15));


            //     //Polimorfismo (execução) e Herança
            // Aluno p1 = new Aluno();
            
            // p1.Nome = "Carlos";
            // p1.Idade = 16;
            // p1.Documento = "1111111";
            // p1.Nota = 8;

            // p1.Apresentar();

            // Professor p2 = new Professor();
            
            // p2.Nome = "José";
            // p2.Idade = 25;
            // p2.Documento = "22222222";
            // p2.Salario = 2000;

            // p2.Apresentar();
        


            //     //Valores válidos encapsulamento
            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30,20);
            
            // System.Console.WriteLine($"Área: {r.ObterArea()}");


            //     //Valores inválidos encapsulamento
            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0,0);
            
            // System.Console.WriteLine($"Área: {r2.ObterArea()}");


            // Pessoa p1 = new Pessoa();
            
            // p1.Nome = "Carlos";
            // p1.Idade = 16;

            // p1.Apresentar();
        }
    }



}