using System;
using System.Globalization;

namespace digiteSuaSenha
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;

            Console.Write("Digite a sua senha com 4 dígitos: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Acesso negado");
                Console.Write("Digite a sua senha com 4 dígitos: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
