using System;
using System.Globalization;

namespace contaDeTelefone
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            string mes;

            Console.Write("digite o mês que você nasceu com 2 digitos: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 == 1)
            {
                mes = "Janeiro";
            }
            else if (n1 == 2)
            {
                mes = "Fevereiro";
            }
            else if (n1 == 3)
            {
                mes = "Março";
            }
            else if (n1 == 4)
            {
                mes = "Abril";
            }
            else if (n1 == 5)
            {
                mes = "Maio";
            }
            else if (n1 == 6)
            {
                mes = "Junho";
            }
            else if (n1 == 7)
            {
                mes = "Julho";
            }
            else if (n1 == 8)
            {
                mes = "Agosto";
            }
            else if (n1 == 9)
            {
                mes = "Setembro";
            }
            else if (n1 == 10)
            {
                mes = "Outrubro";
            }
            else if (n1 == 11)
            {
                mes = "Novembro";
            }
            else if (n1 == 12)
            {
                mes = "Dezembro";
            }
            else
            {
                mes = "Mês inválido";
            }

            Console.WriteLine("Mês escolhido: " + mes);
        }
    }
}
