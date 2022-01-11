using System;

namespace PosicaoDeMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da linha: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor da coluna: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite os valores separando por espaço");
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {                    
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            Console.WriteLine();

            Console.Write("Digite um valor para buscar na matriz: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] == numero)
                    {
                        Console.WriteLine("Posição " + i + ", " + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i,j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + mat[i - 1, j]);
                        }
                        if (i < m - 1 )
                        {
                            Console.WriteLine("Abaixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
