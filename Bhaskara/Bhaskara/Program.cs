using System;
using System.Globalization;


namespace Matemática
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;


            Console.WriteLine("==============================================");
            Console.WriteLine("            FÓRMULA DE BASKARA                ");
            Console.WriteLine("==============================================");

            Console.Write("Digite o valor de A, B e C: ");
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0.0 || delta < 0.0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("O valor do X1 é de: " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("O valor do X2 é de: " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }


        }
    }
}