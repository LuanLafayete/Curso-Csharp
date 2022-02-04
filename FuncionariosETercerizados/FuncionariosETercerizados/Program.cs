using System;
using System.Collections.Generic;
using System.Globalization;
using FuncionariosETercerizados.Entities;

namespace FuncionariosETercerizados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int emp = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= emp; i++)
            {
                Console.WriteLine($"Employee #{i} data");
                Console.Write("OutSourced (y/n): ");
                char choice = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (choice == 'y' || choice == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double charge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutSourceEmployee(name, hours, value, charge));
                }
                else
                {
                    list.Add(new Employee(name, hours, value));
                }
            }
            Console.WriteLine();

            Console.WriteLine("PAYMENTS:");

            foreach(Employee empe in list)
            {
                Console.WriteLine(empe.Name + " - $ " + empe.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
