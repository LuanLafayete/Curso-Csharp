using System;

namespace tipoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0; 
            int diesel = 0;
            int numero;

            Console.WriteLine("Qual combustível você usa no seu veículo? ");
            Console.WriteLine("Digite 1 para Álcool");
            Console.WriteLine("Digite 2 para Gasolina");
            Console.WriteLine("Digite 3 para Diesel");
            Console.WriteLine("Digite 4 para FIM");
            numero = int.Parse(Console.ReadLine());

            while (numero < 4)
            {
                if (numero == 1)
                {
                    alcool = alcool + 1;
                }
                else if (numero == 2)
                {
                    gasolina = gasolina + 1;
                }
                else if (numero == 3)
                {
                    diesel = diesel + 1;
                }

                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Álcool: " + alcool);
            Console.WriteLine("Gasolina : " + gasolina);
            Console.WriteLine("Diesel : " + diesel);
        }
    }
}
