using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTech.Desafios
{
    public class DesafioUm
    {
        public virtual void DesaUm()
        {
            int C = Convert.ToInt32(Console.ReadLine());
            while(C-- > 0)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                int newval = (int)Math.Sqrt(val);        //complete com a sua lógica
                int resposta = val - newval;
                Console.WriteLine(resposta);
            }
        }
    }
}