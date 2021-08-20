using System;
using System.Globalization;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            int peca1, peca2, unit1, unit2;
            double valor1, valor2, totalDeCompra;

            string[] linha = Console.ReadLine().Split(' ');
            peca1 = int.Parse(linha[0]);
            unit1 = int.Parse(linha[1]);
            valor1 = double.Parse(linha[2], CultureInfo.InvariantCulture);

            linha = Console.ReadLine().Split(' ');
            peca2 = int.Parse(linha[0]);
            unit2 = int.Parse(linha[1]);
            valor2 = double.Parse(linha[2], CultureInfo.InvariantCulture);

            totalDeCompra = unit1 * valor1 + unit2 * valor2;


            Console.WriteLine("VALOR A PAGAR: R$ " + totalDeCompra.ToString("F2"), CultureInfo.InvariantCulture);


        }
    }
}