using System;
using System.IO;

string path = @"C:\Users\luanr\Desktop\Programação\file1.txt";

StreamReader sr = null;

try
{
    sr = File.OpenText(path);
    //string line = sr.ReadToEnd(); OPÇÃPO MENOS VERBOSO
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
   
}
catch (IOException e)
{
    Console.WriteLine("An error occured");
    Console.WriteLine(e.Message);
}
finally
{
    if (sr != null) sr.Close();   
}