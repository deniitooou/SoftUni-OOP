using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCaloriesss
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            Name = name;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            }
        }

        public int numberOfToppings
        {
            get { return toppings.Count; }
        }

        public Dough Dough
        {
            set
            {
                dough = value;
            }
        }

        public double TotalCalories
        {
            get{return toppings.Select(t => t.CaloriesPerGram).Sum() + dough.CaloriesPerGram;}
        }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            toppings.Add(topping);
        }
    }
}