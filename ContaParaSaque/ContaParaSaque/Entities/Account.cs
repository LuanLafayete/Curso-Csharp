using System;
using ContaParaSaque.Entities.Exceptions;

namespace ContaParaSaque.Entities
{
    class Account
    {
        public int Numero { get; set; }
        public string Usuario { get; set; }
        public double Saldo { get; set; }
        public double LimiteDeSaque { get; set; }

        public Account()
        {
        }
        
        public Account(int numero, string usuario, double saldo, double limiteDeSaque)
        {
            Numero = numero;
            Usuario = usuario;
            Saldo = saldo;
            LimiteDeSaque = limiteDeSaque;
        }

        public void Deposit(double amount)
        {
            Saldo +=  amount;
        }

        public void saque(double amount)
        {
            // Teste de Saldo insuficiente
            if (amount > Saldo)
            {
                throw new DomainException("Saldo insuficiente");
            }
            // Teste de saque acima do Limite de saque
            if (amount > LimiteDeSaque)
            {
                throw new DomainException ("Valor acima do limite de saque ");
            }          
            
            Saldo -= amount;
        }        

    }
}
