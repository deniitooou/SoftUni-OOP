using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCaloriesss
{
    public class Dough
    {
        private const int CALORIES_PER_GRAM = 2;

        private string flourType;
        private string bakingTehnique;
        private int grams;

        private Dictionary<string, double> flourModifiers = new Dictionary<string, double>()
        {
            {"white", 1.5},
            {"wholegrain", 1.0}
        };

        private Dictionary<string, double> bakingModifiers = new Dictionary<string, double>()
        {
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0 }
        };

        public Dough(string flourType, string bakingTehnique, int grams)
        {
            FlourType = flourType;
            BakingTehnique = bakingTehnique;
            Grams = grams;
        }

        private string FlourType
        {
            set
            {
                if (!flourModifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value.ToLower();
            }
        }

        private string BakingTehnique
        {
            set
            {
                if (!bakingModifiers.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTehnique = value.ToLower();
            }
        }

        private int Grams
        {
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                grams = value;
            }
        }

        public double CaloriesPerGram
        {
            get{return CALORIES_PER_GRAM * grams * flourModifiers[flourType] * bakingModifiers[bakingTehnique];}
        }
    }
}