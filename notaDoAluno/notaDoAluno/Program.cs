using System;
using System.Globalization;

namespace notaDoAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double score1, score2, total;

            Console.Write("Resuldado da primeira prova: ");
            score1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Resuldado da segunda prova: ");
            score2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = score1 + score2;

            if (total >= 60.00)
            {
                Console.WriteLine("Seu resultado foi: " + total.ToString("f2"),CultureInfo.InvariantCulture);
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("Seu resultado foi: " + total.ToString("f2"),CultureInfo.InvariantCulture);
                Console.WriteLine("REPROVADO");
            }


        }
    }
}
