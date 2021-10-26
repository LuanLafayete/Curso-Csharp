using System;
using System.Globalization;

//Conversor de moeda passando por instanciação.

namespace ConversorDeMoeda03
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertorDeMoeda conv = new ConvertorDeMoeda();

            Console.Write("Qual é a cotação do dólar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = conv.Converter(dolar, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
