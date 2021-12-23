using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.Entities.ExerciseProducts
{
    class UsedProduct : Product
    {
        private DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + "(Manufacture date: " + ManufactureDate + ")";
        }
    }
}
