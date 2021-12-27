using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.AbstractExercise.Q1
{
    class Circle : Shape
    {
        private double radius { get; set; }

        public Circle(double radius, string color) :  base(color)
        {
            Color = color;
            this.radius = radius;
        }

        public override double Area()
        {
            
            return Math.PI * radius * radius;
        }

       
    }
}
