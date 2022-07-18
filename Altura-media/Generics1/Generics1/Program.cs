using System;
using Generics1.Service;

PrinterService<int> printService = new PrinterService<int>();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    printService.AddValue(x);
}

int a = printService.First();
int b = a + 2;
Console.WriteLine(b);

printService.Print();

Console.WriteLine("First: " + printService.First());