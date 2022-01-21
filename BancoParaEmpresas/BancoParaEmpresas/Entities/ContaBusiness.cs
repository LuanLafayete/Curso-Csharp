namespace BancoParaEmpresas.Entities
{
    class ContaBusiness : Conta
    {
        public double LimiteDeEmprestimo { get; set; }

        public ContaBusiness()
        {
        }

        public ContaBusiness(int numero, string usuário, double saldo, double limiteDeEmprestimo) : base (numero, usuário, saldo)
        {
            LimiteDeEmprestimo = limiteDeEmprestimo;
        }

        public void Emprestimo(double quantia)
        {
            if (quantia <= LimiteDeEmprestimo)
            {
                Saldo += quantia;
            }            
        }

    }
}
