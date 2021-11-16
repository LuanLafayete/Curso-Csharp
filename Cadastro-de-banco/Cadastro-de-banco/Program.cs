using System;
using System.Globalization;

namespace Cadastro_de_banco
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Acesso aos dados do cliente
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char seletor = char.Parse(Console.ReadLine());            

            //Laço de repetição para coletar a resposta SIM ou NÃO
            while (seletor != 's' && seletor != 'n')
            {
                Console.WriteLine("Dados incorretos");
                Console.Write("Haverá depósito inicial (s/n)? ");
                seletor = char.Parse(Console.ReadLine());
            }

            //Se o cliente disser SIM
            if (seletor == 's' || seletor == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                Console.WriteLine("Dados da conta:");
                Console.WriteLine("Conta "
                    + conta
                    + ", Titular: "
                    + nome
                    + ", Saldo: "
                    + "$ "
                    + valorInicial.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();

                ////Cliente realiza o depósito
                Console.Write("Entre um valor para depósito: ");
                double depositoComEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double totalComEntrada = valorInicial + depositoComEntrada;

                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine("Conta "
                    + conta
                    + ", Titular: "
                    + nome
                    + ", Saldo: "
                    + "$ "
                    + totalComEntrada.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();

                //Cliente realiza o saque
                Console.Write("Entre um valor para saque: ");
                double saqueComEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double financeiro = (totalComEntrada - saqueComEntrada) - 5.00;

                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine("Conta "
                    + conta
                    + ", Titular: "
                    + nome
                    + ", Saldo: "
                    + "$ "
                    + financeiro.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                //Se o cliente disser NÃO
                Console.WriteLine();

                Console.WriteLine("Dados da conta: Conta :");
                Console.WriteLine("Conta "
                        + conta
                        + ", Titular: "
                        + nome
                        + ", Saldo: "
                        + "$ 0.00");


                Console.WriteLine();

                //Cliente realiza o depósito
                Console.Write("Entre um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Dados da conta atualizados: ");
                Console.WriteLine("Conta "
                        + conta
                        + ", Titular: "
                        + nome
                        + ", Saldo: "
                        + "$ "
                        + deposito.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine();

                //Cliente realiza o saque
                Console.Write("Entre um valor para saque: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double total = (deposito - saque) - 5.00;

                Console.WriteLine("Dados da conta atualizados:");
                Console.WriteLine("Conta "
                       + conta
                       + ", Titular: "
                       + nome
                       + ", Saldo: "
                       + "$ "
                       + total.ToString("F2", CultureInfo.InvariantCulture));

            
            }
        }
    }
}
