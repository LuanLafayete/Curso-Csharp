using System;
using System.Globalization;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, esfera;
            int raio;

            raio = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            esfera = (double)(4 / 3.0) * pi * Math.Pow(raio, 3.0);

            Console.WriteLine("VOLUME = " + esfera.ToString("F3"), CultureInfo.InvariantCulture);


        }
    }
}
