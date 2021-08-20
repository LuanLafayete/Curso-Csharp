using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, precoMetroQuadrado, area, precoFinal;

            Console.Write("Digite o tamanho da Largura: ");
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o tamanho do Comprimento: ");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o Preço do Metro Quadrado: ");
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = largura * comprimento;
            precoFinal = area * precoMetroQuadrado;

            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = " + precoFinal.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}