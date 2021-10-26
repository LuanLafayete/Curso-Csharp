using System;
using System.Globalization;

//Conversor de moeda desenvolvido passando por método dentro da mesma class.

namespace ConversorDeMoeda02
{
    class Program
    {
        static double IOF = 6.0;

        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = Converter(dolar, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Converter(double Dolar, Double Quantidade)
        {
            double total = Dolar * Quantidade;
            return total + total * IOF / 100;
        }
    }
}
