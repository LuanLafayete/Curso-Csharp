using System;

namespace MatrizComSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanha do matriz: ");
            int ma = int.Parse(Console.ReadLine());

            int[,] mat = new int[ma, ma];

            for (int i = 0; i < ma; i++)
            {
                Console.WriteLine("Digite " + ma + " separando por espaço: ");
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < ma; j++)
                {
                    mat[i, j] = int.Parse(valor[j]);
                }
            }

            Console.Write("Diagonal Principal: ");
            for (int i = 0; i < ma; i++ )
            {
                Console.Write(mat[i,i] + " ");
            }

            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < ma; i++)
            {
                for (int j = 0; j < ma; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.Write("Números Negativos: " + count);
        }
    }
}
