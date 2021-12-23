using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.AbstractExercise
{
    class Rectangle :  Shape
    {
        private double width { get; set; }
        private double height { get; set; }

        public Rectangle(double width, double height, string color)
        {
            Color = color;
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            double area = width * height;
            return area;
        }
        
    }
}
