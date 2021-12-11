using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] arg)
        {
                //Evento
            Matematica m = new Matematica(10, 12);
            m.Somar();

            
                //Delegates
            // Operacao op = Calculadora.Somar;
            // Operacao op2 = new Operacao(Calculadora.Subtrair);
            // op += Calculadora.Subtrair //Multicast Delegate

            // op.Invoke(10, 10);
            // op2(20, 10);

                //Constante
            // const double pi = 3.14;
            // System.Console.WriteLine(pi);

                //Get Set
            // Data data = new Data();
            // data.SetMes(6);

            // data.ApresentarMes();

                //Construtor Herança
            // Aluno a1 = new Aluno("Joana", "Silva", "Matemática");
            // a1.Apresentar();

                //Construtor Privado
            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste Instancia";
            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            // Pessoa p1 = new Pessoa("Maria", "Silva");
            // p1.Apresentar();
        }
    }
}