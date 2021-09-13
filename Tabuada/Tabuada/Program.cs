using System;
using System.Globalization;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resultado;

            Console.Write("Qual taboada você quer saber: ");
            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado );
            }
        }
    }
}
