using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListaDeFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão cadastrados: ");
            int qtd = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <=qtd; i++)
            {
                Console.WriteLine($"Funcionário #{i}: ");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome; ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Coloque o ID do funcionário que receberá aumento de salário ");
            int IdAleatorio = int.Parse(Console.ReadLine());

            Funcionario empregado = list.Find(x => x.Id == IdAleatorio);
            if (empregado != null)
            {
                Console.Write("Coloque a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empregado.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse ID não existe!" );
            }

            Console.WriteLine();
            Console.WriteLine("Atualização da lista de funcionários: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
