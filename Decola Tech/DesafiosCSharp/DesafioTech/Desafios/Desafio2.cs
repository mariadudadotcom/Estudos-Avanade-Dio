namespace DesafioTech.Desafios
{
    public class DesafioDois
    {
        public virtual void DesaDois()
        {

            int N = int.Parse(Console.ReadLine());
            int b = 2;

            for (int i = 0; i < 10; i++)
            {

                while (N>=b)
                {
                    System.Console.WriteLine(b + "^2=" + Math.Pow(b, 2));
                    b+=2;
                }
            }               

        }
    }
}