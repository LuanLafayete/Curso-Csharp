using System;
using System.IO;

string sourcePath = @"C:\Users\luanr\Desktop\Programação\file1.txt";
string targetPath = @"C:\Users\luanr\Desktop\Programação\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);

    string[] Lines = File.ReadAllLines(sourcePath);
    foreach (string txt in Lines)
    {
        Console.WriteLine(txt);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);
}