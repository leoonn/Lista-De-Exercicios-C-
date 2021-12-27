using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.AbstractExercise.Q2
{
    class PessoaFisica : Contribuinte
    {
        double spendHealth { get; set; }
        public PessoaFisica(string name, double income, double spend) : base(name, income)
        {
            spendHealth = spend;
        }

        public override double Calculate()
        {
            double tax;
            double result;
            if(Income >= 20000 )
            {
                tax = 0.25;
                if (spendHealth > 0)
                {
                    result = (Income * tax) - (spendHealth / 2); 
                }else
                {
                    result = (Income * tax);
                }
            }
            else
            {
                tax = 0.15;
                if (spendHealth > 0)
                {
                    result = (Income * tax) - (spendHealth / 2);
                }
                else
                {
                    result = (Income * tax);
                }
            }
            return result;
        }
    }
}
