using System;
using Interface3.Model;

var s = new Scanner() { SerialNumber = 2003 };
s.ProcessDoc("My Email");
Console.WriteLine(s.Scan());

Console.WriteLine();

Printer p = new Printer() {SerialNumber = 1080 };
p.ProcessDoc("My letter");
p.Print("My letter");

Console.WriteLine();

ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
c.ProcessDoc("My dissertation");
c.Print("My dissertation");
Console.WriteLine(c.Scan());