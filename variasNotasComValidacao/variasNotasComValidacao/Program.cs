using System;
using System.Globalization;

namespace variasNotasComValidacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, nota1, nota2;
            int escolha;

            Console.WriteLine("Deseja calcular a média?");
            Console.Write("Digite: 1 para SIM ou 2 para NÃO: ");
            escolha = int.Parse(Console.ReadLine());

            while (escolha == 1)
            {                               
                Console.Write("Digite o resultado da primeira prova: ");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);               
                while (nota1 < 0 || nota1 > 10)
                {
                    Console.WriteLine("NOTA INVÁLIDA");
                    Console.Write("Digite o resultado da primeira prova: ");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                Console.Write("Digite o resultado da segunda prova: ");
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("NOTA INVÁLIDA");
                    Console.Write("Digite o resultado da primeira prova: ");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                media = (nota1 + nota2) / 2.0;
                Console.WriteLine("A media das notas é: " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("Deseja continuar a operação?");
                Console.Write("Digite 1 para SIM e 2 para NÃO: ");
                escolha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("FIM DO PROCESSO");
        }
    }
}
