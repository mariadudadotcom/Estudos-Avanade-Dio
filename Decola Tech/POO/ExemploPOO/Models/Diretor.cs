namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou o diretor {Nome}, tenho {Idade} anos e meu salário é de {Salario}");
        }
    }
}