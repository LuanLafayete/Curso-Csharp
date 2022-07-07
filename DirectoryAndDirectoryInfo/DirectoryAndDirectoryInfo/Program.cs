using System;
using System.IO;

string path = @"C:\Users\luanr\Desktop\Programação\My folder";

try
{
    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS: ");
    foreach (var s in folders)
    {        
        Console.WriteLine(s);
    }

    Console.WriteLine();

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FILES: ");
    foreach (var f in files)
    {        
        Console.WriteLine(f);
    }

    Directory.CreateDirectory(path + "\\New Folder");
}
catch (IOException e)
{
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}