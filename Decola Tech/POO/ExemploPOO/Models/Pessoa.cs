using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade, string documento)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Documento = documento;

        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Documento { get; set; }


        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
            this.Documento = "";
        }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é: {Nome} e tenho {Idade} anos");

        }



    }
}