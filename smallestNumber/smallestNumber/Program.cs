﻿using System;
using System.Globalization;

namespace Matemática
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("========================================");
            Console.WriteLine("        Qual é o menor número?          ");
            Console.WriteLine("========================================");

            Console.Write("Digite o primeiro número: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            c = int.Parse(Console.ReadLine());

            if (a < b && a < c)
            {
                Console.WriteLine("O menor número é o: " + a);
            }
            else
            {
                if (b < c)
                {
                    Console.WriteLine("O menor número é o: " + b);
                }
                else
                {
                    Console.WriteLine("O menor número é o: " + c);
                }

            }
        }
    }
}
