using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)

            //Atividade prática para calcular a área de uma circunferência. 
            //O usuário apresenta os dados e o programa faz o calculo usando PI x a potência do dado apresentado pelo usuário. 
        {
            double n = 3.14159, area, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * Math.Pow(raio, 2);

            Console.WriteLine("Area = " + area.ToString("F4"), CultureInfo.InvariantCulture);

        }
    }
}
