using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.AbstractExercise.Q2
{
   abstract class Contribuinte
    {
        public String Name { get; set; }
        public double Income { get; set; }

        protected Contribuinte(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Calculate();


    }
}
