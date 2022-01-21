using System;
using BancoParaEmpresas.Entities;

namespace BancoParaEmpresas
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBusiness conta = new ContaBusiness(8010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(conta.Saldo);

          //conta.Saldo = 200.0;     AQUI PRESENCIAMOS UM ERRO PQ O SALDO NA CLASS CONTA ESTÁ COM PROTECT
        }
    }
}
