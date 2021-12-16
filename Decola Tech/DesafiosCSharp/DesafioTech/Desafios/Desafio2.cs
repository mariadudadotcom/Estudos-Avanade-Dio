namespace DesafioTech.Desafios
{
    public class DesafioDois
    {
        public virtual void DesaDois()
        {
            int n = int.Parse(Console.ReadLine());
      
            for (int i = 1; i <= n; i++)
            {
      	        if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}^2 = {i*i}");
                }
                            
            }               

        }
    }
}