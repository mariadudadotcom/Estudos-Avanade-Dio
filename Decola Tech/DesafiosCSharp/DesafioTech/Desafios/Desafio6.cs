namespace DesafioTech.Desafios
{
    public class DesafioSeis
    {
        public virtual void DesaSeis()
        {
            int x = int.Parse(Console.ReadLine());
            if(x % 2 == 0)
            {
                System.Console.WriteLine($"{x + 2}");
            }
            else
            {
                System.Console.WriteLine($"{x + 1}");
            }
        }
    }
}