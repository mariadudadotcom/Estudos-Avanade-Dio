namespace DesafioTech.Desafios
{
    public class DesafioQuatro
    {
        public virtual void DesaQuatro()
        {
            for(int I = 1; I < 10; I+= 2)
            {
                for(int J = 7; J >= 5; J -= 1)    //escreva seu código nos espaços em branco
                {
                    Console.WriteLine($"I={I} J={J}");
                }
            }
        }
    }
}