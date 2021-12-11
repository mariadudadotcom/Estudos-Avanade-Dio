using System;
namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool MesValido;

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if (mes >0 && mes <=12)
            {
                this.mes = mes;
                this.MesValido = true;
            }
        }

                //Propriedades Get Set
        // public int Mes 
        // { 
        //     get
        //     {
        //         return this.Mes;
        //     }
        //     set
        //     {
        //         if(value >0 && value <= 12)
        //         {
        //             this.mes = value;
        //             this.MesValido = true;
        //         }
        //     }
            
        // }
        public void ApresentarMes()
        {
            if(this.MesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mês Inválido");
            }
        }
    }
}