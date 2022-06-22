﻿using System;
using PraticaDeMetodosAbstratos.Entities.Enuns;

namespace PraticaDeMetodosAbstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base (color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
