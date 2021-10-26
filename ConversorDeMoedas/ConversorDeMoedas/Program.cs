using System;
using System.Globalization;

//Conversor de moeda passando por objeto static.

namespace ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar: ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.converter(dolar, quantidade);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
