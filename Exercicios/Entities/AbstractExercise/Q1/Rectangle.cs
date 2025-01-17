﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.AbstractExercise.Q1
{
    class Rectangle :  Shape
    {
        private double width { get; set; }
        private double height { get; set; }

        public Rectangle(double width, double height, string color) : base(color)
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
