namespace DesafioTech.Desafios
{
    public class DesafioCinco
    {
        public virtual void DesaCinco()
        {
            string str;
            while((str=Console.ReadLine())!= null)
            {
                    int x = int.Parse(str);
                    if (x==0)
                    {
                    Console.WriteLine( "vai ter copa!"  ); 
                    }
                    else          //Escreva o seu código nos espaços em branco
                    {
                        Console.WriteLine( "vai ter duas!" );
                    }

            }
        }
    }
}