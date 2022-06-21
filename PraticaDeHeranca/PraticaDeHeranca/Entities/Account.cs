namespace PraticaDeHeranca.Entities
{
    class Account

        //ATRIBUTOS
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }


        //CONSTRUTORES
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //MÉTODOS

        public virtual void Withdraw (double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
