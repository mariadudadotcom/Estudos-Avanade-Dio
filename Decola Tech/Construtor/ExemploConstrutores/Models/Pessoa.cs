namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
                 //ReadOnly
        // private readonly string nome = "José";
        // private readonly string sobrenome;
        private string nome;
        private string sobrenome;

        // public Pessoa()
        // {
        //     nome = string.Empty;
        //     sobrenome = string.Empty;
        // }
        public Pessoa (string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor Classe Pessoa");
        }
        public void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {nome} {sobrenome}");
        }
    }
}