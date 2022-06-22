using System;
using System.Globalization;
using System.Collections.Generic;
using PagandoImpostos.Entities;

List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");

    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if (ch == 'i' || ch == 'I')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        list.Add(new Individual(healthExpenditures, name, anualIncome));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        list.Add(new Company(numberOfEmployees, name, anualIncome));
    }
}

Console.WriteLine();

Console.WriteLine("TAXES PAID:");

double sum = 0;

foreach (TaxPayer payer in list)
{
    double tax = payer.Tax();
    Console.WriteLine(payer.Name + ": $ " + payer.Tax().ToString("F2", CultureInfo.InvariantCulture));
    sum += tax;
}

Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));