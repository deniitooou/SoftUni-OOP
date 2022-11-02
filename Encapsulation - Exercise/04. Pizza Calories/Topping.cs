using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCaloriesss
{
    public class Topping
    {
        private const int CALORIES_PER_GRAM = 2;

        private string toppingType;
        private int grams;
        private Dictionary<string, double> toppingModifiers = new Dictionary<string, double>()

        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };

        public Topping(string toppingType, int grams)
        {
            ToppingType = toppingType;
            Grams = grams;
        }

        private string ToppingType
        {
            set
            {
                if (!toppingModifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                toppingType = value;
            }
        }
        private int Grams
        {
            set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{toppingType} weight should be in the range [1..50].");
                }
                grams = value;
            }
        }

        public double CaloriesPerGram
        {
            get
            {
                return CALORIES_PER_GRAM * grams * toppingModifiers[toppingType.ToLower()];
            }
        }
    }
}