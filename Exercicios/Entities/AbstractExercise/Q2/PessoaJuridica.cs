using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.AbstractExercise.Q2
{
    class PessoaJuridica : Contribuinte
    {
        public int Employee { get; set; }
        public PessoaJuridica(string name, double income, int emp) : base(name, income)
        {
            Employee = emp;
        }

        public override double Calculate()
        {
            double tax;
            double result;
            if (Employee > 10)
            {
                tax = 0.16;
                result = (Income * tax);
            }
            else
            {
                tax = 0.14;
                result = (Income * tax);
            }
            return result;
        }
    }
}
