using System;
using System.Globalization;

namespace ConversorDeTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            char repetir;

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                celsius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                fahrenheit = (9.0 * celsius / 5.0) + 32.0;
                Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit.ToString("F1", CultureInfo.InvariantCulture));

                Console.Write("Deseja repetir (s/n)? ");
                repetir = char.Parse(Console.ReadLine());

            } while (repetir == 's');          

            Console.WriteLine("FIM DO PROGRAMA");
        }
    }
}
