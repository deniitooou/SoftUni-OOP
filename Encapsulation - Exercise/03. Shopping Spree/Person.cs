using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Products = new List<Product>();
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty");

                this.name = value;
            }
        }
        public decimal Money
        {
            get { return this.money; }
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Money cannot be negative");

                this.money = value;
            }
        }

        public List<Product> Products
        {
            get { return this.products; }
            private set { this.products = value; }
        }

        public void BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.products.Add(product);
                this.Money -= product.Cost;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else Console.WriteLine($"{this.Name} can't afford {product.Name}");
        }
    }
}