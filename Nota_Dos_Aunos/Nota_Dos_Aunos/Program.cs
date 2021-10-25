using System;
using System.Globalization;

namespace Nota_Dos_Aunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno capiroto = new Aluno();

            Console.Write("Nome do aluno: ");
            capiroto.nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas dos alunos");
            capiroto.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            capiroto.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            capiroto.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL " + capiroto.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                      
            if (capiroto.NotaFinal() >= 60.00)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                double limite = 60.00 - capiroto.NotaFinal();
                Console.Write("FALTARAM " + limite.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }

        }
    }
}
