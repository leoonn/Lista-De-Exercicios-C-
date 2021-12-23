using System.Globalization;

namespace Exercicios.Entities.ExerciseProducts
{
    class Product
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public virtual string PriceTag()
        {
            return name + " $" + price.ToString("F2", CultureInfo.InvariantCulture );
        }
    }
}
