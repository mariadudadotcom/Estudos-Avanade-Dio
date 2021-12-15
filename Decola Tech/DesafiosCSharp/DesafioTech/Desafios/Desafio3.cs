using System;

namespace DesafioTech.Desafios
{
    public class DesafioTres
    {
        public virtual void DesaTres()
        {
            double c, S= 0;
            for (double a = 1; a <= 100; a++)
            {
                c = (1 / a);
                S += c;
            }
            double x = Math.Round(S, 2);
            Console.WriteLine(x);
        }
            
    }
}