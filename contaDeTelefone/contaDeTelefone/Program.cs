using System;
using System.Globalization;

namespace contaDeTelefone
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double contas = 50.00;

            Console.Write("Quantos minutos foram consumidos? ");
            minutos = int.Parse(Console.ReadLine());

            if (minutos < 100)
            {
                Console.Write("VALOR TOTAL = " + contas.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                contas = contas + (minutos - 100) * 2.00;
                Console.WriteLine("VALOR TOTAL = " + contas.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
