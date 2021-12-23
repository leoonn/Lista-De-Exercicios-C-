using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.AbstractExercise
{
    class Circle : Shape
    {
        private double radius { get; set; }

        public Circle(double radius, string color)
        {
            Color = color;
            this.radius = radius;
        }

        public override double Area()
        {
            double area = radius / 2;
            return area;
        }

       
    }
}
