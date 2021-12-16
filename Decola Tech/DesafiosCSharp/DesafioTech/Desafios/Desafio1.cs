using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTech.Desafios
{
    public class DesafioUm
    {
        public virtual void DesaUm()
        {
            int resposta = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            while(N-- > 0)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                int r = (int)Math.Sqrt(c);
                int s = c - r;
                resposta = s;
            }
            Console.WriteLine(resposta);
        }
    }
}