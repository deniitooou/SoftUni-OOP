namespace WildFarm.Models.Foods
{
    using Interfaces;

    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.Quantity}";
        }
    }
}