using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        private string Name;
        private string FavouriteFood;

        public Animal(string name, string favouriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf ()
        {
            return ($"I am {this.Name} and my favourite food is {this.FavouriteFood}");
            
        }
    }

}

