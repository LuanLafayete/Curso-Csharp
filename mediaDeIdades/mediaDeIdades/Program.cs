using System;
using System.Globalization;

namespace mediaDeIdades
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, idade, soma, contador;

            Console.WriteLine("Quando anos os alunos tem? ");
            idade = int.Parse(Console.ReadLine());

            soma = 0;
            contador = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                contador = contador + 1;
                Console.WriteLine("Quando anos os alunos tem? ");
                idade = int.Parse(Console.ReadLine());
            }

            if (contador > 0)
            {
                media = soma / contador;
                Console.WriteLine("A media de idade dos alunos é de: " + media.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Impossível calcular");
            }
        }
    }
}