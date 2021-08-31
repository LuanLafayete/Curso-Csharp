using System;
using System.Globalization;

namespace idadeMediaDosAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;
            int cont = 0;
            int soma = 0;
            double media;

            Console.WriteLine("Digite a idade dos usuários do Asilo: ");
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                cont = cont + 1;
                soma = soma + idade;
                idade = int.Parse(Console.ReadLine());
            }

           
            media = (double)soma / cont;
            Console.WriteLine("A média de idade dos usuários do asilo é: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
