using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.AbstractExercise.Q1
{
   abstract class Shape
    {
        public string Color { get; set; }

        protected Shape(string color)
        {
            Color = color;
        }

        public abstract double Area();
        
    }
}
