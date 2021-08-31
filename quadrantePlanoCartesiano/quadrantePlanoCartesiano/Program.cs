using System;

namespace quadrantePlanoCartesiano
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de X e Y: ");
            string[] valores = Console.ReadLine().Split(' ');           
            int x = int.Parse(valores [0]);
            int y = int.Parse(valores[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else
                {
                    Console.WriteLine("Quarto Quadrante");
                }
                Console.Write("Digite o valor de X e Y: ");
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y = int.Parse(valores[1]);
            }

            



        }
    }
}
