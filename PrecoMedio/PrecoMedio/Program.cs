using System;
using System.Globalization;

namespace PrecoMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos produtos serão utilizados? ");
            int qtd = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[qtd];

            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Digite o nome do produto");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vetor[i] = new Produto {Nome = nome, Preco = preco};
            }

            double soma = 0.0;

            for (int i = 0; i < qtd; i++)
            {
                soma += vetor[i].Preco;
            }

            double media = soma / qtd;
            Console.WriteLine("AVERAGE PRICE = " + media.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
