using System;
using System.IO;

string sourcePath = @"C:\Users\luanr\Desktop\Programação\file1.txt";
string targetPath = @"C:\Users\luanr\Desktop\Programação\file2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);
    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occured!");
    Console.WriteLine(e.Message);
}