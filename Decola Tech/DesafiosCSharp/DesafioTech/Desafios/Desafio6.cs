namespace DesafioTech.Desafios
{
    public class DesafioSeis
    {
        public virtual void DesaSEIS()
        {
            int x = int.Parse(Console.ReadLine());
            if(x % 2 == 0)
            {
                x = x + 2;
            }
            else
            {
                x = x + 1;
            }

            System.Console.WriteLine(x);
        }
    }
}