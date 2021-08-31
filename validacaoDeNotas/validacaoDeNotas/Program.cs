using System;
using System.Globalization;

namespace validacaoDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            Console.Write("Digite o resultado da primeira prova: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Nota Inválida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.Write("Digite o resultado da segunda prova: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Nota Inválida");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = (nota1 + nota2) / 2;

            Console.WriteLine("A media das provas é: " + media.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
