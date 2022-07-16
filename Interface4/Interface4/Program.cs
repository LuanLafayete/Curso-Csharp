using System;
using System.Globalization;

string caminho = @"C:\Users\luanr\Desktop\Programação\01-Curso C Sharp\Interface4\Document.txt";

try
{
    using (StreamReader sr = File.OpenText(caminho))
    {
        List<string> list = new List<string>();
        while (!sr.EndOfStream)
        {
            list.Add(sr.ReadLine());
        }
        list.Sort();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("Error to open the file");
    Console.WriteLine(e.Message);
}