using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoParaEmpresas.Entities
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Usuario { get; private set; }
        public double Saldo { get; protected set; } //Quando uso o PROTECTED, minhas subclasses também podem ter acesso ao atributo.

        public Conta()
        {
        }

        public Conta(int numero, string usuário, double saldo)
        {
            Numero = numero;
            Usuario = usuário;
            Saldo = saldo;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }
    }
}
