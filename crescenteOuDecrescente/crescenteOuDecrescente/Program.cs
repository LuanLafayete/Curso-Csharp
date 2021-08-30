using System;
using System.Globalization;

namespace crescenteOuDecrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Digite o primeiro valor");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }

                Console.WriteLine("Digite o primeiro valor");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo valor");
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
