using System;
using System.Globalization;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFunc, horasTrab;
            double sal, totalSal;

            numFunc = int.Parse(Console.ReadLine());
            horasTrab = int.Parse(Console.ReadLine());
            sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalSal = sal * horasTrab;

            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine("SALARY = U$ " + totalSal.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}
