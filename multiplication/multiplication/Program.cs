using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, Prod;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Prod = a * b;

            Console.WriteLine("PROD = " + Prod);

        }
    }
}
