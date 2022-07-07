using System;
using System.IO;

string path = @"C:\Users\luanr\Desktop\Programação\file1.txt";


try
{

    using (StreamReader sr = File.OpenText(path))
    {
        string line = sr.ReadToEnd();
        Console.WriteLine(line);
    }

}
catch (IOException e)
{
    Console.WriteLine("An error occured!");
    Console.WriteLine(e.Message);
}
