using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            Char resp = char.Parse(Console.ReadLine());

            while (resp != 's' && resp != 'S' && resp != 'n' && resp != 'N' )
            {
                Console.WriteLine("Dado incorreto!");
                Console.Write("Haverá depósito inicial (s/n)? ");
                resp = char.Parse(Console.ReadLine());
            }

            if (resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Entre uma valor para depósito: ");
            double dinheiro = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(dinheiro);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre uma valor para saque: ");
            dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(dinheiro);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
