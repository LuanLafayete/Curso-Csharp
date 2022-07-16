using System;
using System.Globalization;
using Interface2.Model.Entities;
using Interface2.Model.Enums;

AbstractShape S1 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
AbstractShape S2 = new Circle() { Radius = 2.0, Color = Color.White };

Console.WriteLine(S1);
Console.WriteLine(S2);