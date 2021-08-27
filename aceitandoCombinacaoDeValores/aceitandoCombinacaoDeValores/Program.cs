using System;
using System.Globalization;

namespace contaDeTelefone
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.Write("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            c = int.Parse(Console.ReadLine());

            Console.Write("Digite o quarto número: ");
            d = int.Parse(Console.ReadLine());

            // B > C
            // D > A
            // C + D > A + B
            //C && D > 0
            // A / 2


            if (b > c && d > a && c + d > a + b && c > 0 && d > 0 && (a % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores não aceitos");
            }
        }
    }
}
