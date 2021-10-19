using System;
using System.Globalization;

namespace Cadastro_De_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            a.nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            b.nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (a.sal + b.sal) / 2;

            Console.WriteLine("Salário medio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
