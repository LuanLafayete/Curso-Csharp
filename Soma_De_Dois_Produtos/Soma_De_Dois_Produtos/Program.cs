using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, SOMA;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            SOMA = a + b;

            Console.WriteLine("SOMA = " + SOMA);

        }
    }
}