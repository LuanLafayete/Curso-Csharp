using System;
using System.Globalization;

namespace Altura_media
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas pessoas serão medidas? ");
            int pessoas = int.Parse(Console.ReadLine());

            double[] vetor = new double[pessoas];

            for (int i = 0; i < pessoas; i++)
            {
                Console.Write("Digite a altura: ");
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0.0;

            for (int i = 0; i < pessoas; i++)
            {
                soma += vetor[i];
            }

            double media = soma / pessoas;

            Console.WriteLine("A media da altura das pessoas é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
