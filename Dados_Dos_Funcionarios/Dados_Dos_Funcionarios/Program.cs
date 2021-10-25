using System;
using System.Globalization;

namespace Dados_Dos_Funcionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Cadastro cad = new Cadastro();

            Console.Write("Nome: ");
            cad.nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            cad.Sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Imposto ");
            cad.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine(cad);

            Console.WriteLine("");
            Console.Write("Digite a porcentagem para aumenter o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cad.AumentarSalario(porcentagem);

            Console.WriteLine("");
            Console.WriteLine(cad);


        }
    }
}
