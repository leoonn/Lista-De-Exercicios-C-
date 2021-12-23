using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicios.Entities.ExerciseProducts
{
    class ImportedProduct : Product
    {
        private double customsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee): base(name, price)
        {
           this.customsFee = customsFee;
        }

        public override string PriceTag()
        {
            return name + " $" + TotalPrice() + " (Customs Fee: $" + customsFee.ToString("F2", CultureInfo.InvariantCulture ) + ")";
        }

        public double TotalPrice()
        {
            return price + customsFee;
        }
    }
}
