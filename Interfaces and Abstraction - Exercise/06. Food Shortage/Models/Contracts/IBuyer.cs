namespace FoodShortage
{
    public interface IBuyer
    {
        int Food { get; set; }

        string Name { get; set; }

        void BuyFood();
    }
}