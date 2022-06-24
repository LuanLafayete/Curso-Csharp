using System;
using System.Globalization;
using ContaParaSaque.Entities.Exceptions;
using ContaParaSaque.Entities;


    Console.WriteLine("Entre com as informações da conta");

    Console.Write("Número da conta: ");
    int numero = int.Parse(Console.ReadLine());

    Console.Write("Nome do usuário: ");
    string usuario = Console.ReadLine();

    Console.Write("Saldo inicial: ");
    double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Limite de Saque: ");
    double limiteDeSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Account Conta = new Account(numero, usuario, saldo, limiteDeSaque);

    Console.WriteLine();

    Console.Write("Entre com o valor para saque: ");
    double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

try
{
    Conta.saque(amount);

    Console.WriteLine("Novo saldo: " + Conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));

}
catch (DomainException e)
{
    Console.WriteLine("Erro de saque: " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("Erro ao digitar " + e.Message);
}