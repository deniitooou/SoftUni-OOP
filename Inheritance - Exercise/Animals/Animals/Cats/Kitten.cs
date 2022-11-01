namespace Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, "FEMALE") {}
        public override string ProduceSound() => "Meow";
    }
}
