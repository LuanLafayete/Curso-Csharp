using System;
using System.Globalization;
using System.Collections.Generic;
using PrecoDoProduto.Entities;


Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> list = new List<Product>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product # {i} data");

    Console.Write("Common, used or imported (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    if (ch == 'i' || ch == 'I')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine());
        list.Add(new ImportedProduct(name, price, customsFee));
    }
    else if (ch == 'u' || ch == 'U')
    {
        Console.Write("Manufacture date: ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price,manufactureDate));
    }
    else
    {
        list.Add(new Product(name, price));
    }
}

Console.WriteLine();

Console.WriteLine("PRICE TAGS:");

foreach (Product prod in list)
{
    Console.WriteLine(prod.PriceTag());
}