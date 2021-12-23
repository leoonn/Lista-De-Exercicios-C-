using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.AbstractExercise
{
   abstract class Shape
    {
        public string Color { get; set; }

        public abstract double Area();
        
    }
}
