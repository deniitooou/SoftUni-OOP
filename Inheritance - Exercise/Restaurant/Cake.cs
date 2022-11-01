namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double CAKE_DEFAULT_GRAMS = 250;
        private const double CAKE_DEFAULT_CALORIES = 1000;
        private const decimal CAKE_DEFAULT_PRICE = 5;

        public Cake(string name) : base(name, CAKE_DEFAULT_PRICE, CAKE_DEFAULT_GRAMS, CAKE_DEFAULT_CALORIES)
        {
            this.Grams = CAKE_DEFAULT_GRAMS;
            this.Calories = CAKE_DEFAULT_CALORIES;
            this.Price = CAKE_DEFAULT_PRICE;
        }
    }
}
