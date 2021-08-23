using System;
using System.Globalization;

namespace area_perimetro_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendaBruta, bonus, salarioTotal;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendaBruta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            bonus = vendaBruta * 15 / 100;
            salarioTotal = salario + bonus;

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
