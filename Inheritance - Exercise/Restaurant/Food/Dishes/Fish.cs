namespace Restaurant
{
    public class Fish : MainDish
    {
        private const double FISH_DEFAULT_GRAMS = 22;

        public Fish(string name, decimal price) : base(name, price, FISH_DEFAULT_GRAMS)
        {
          this.Grams = FISH_DEFAULT_GRAMS;
        }
    }
}
