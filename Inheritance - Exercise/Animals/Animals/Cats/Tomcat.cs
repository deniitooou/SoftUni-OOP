namespace Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, "MALE") {}
        public override string ProduceSound() => "MEOW";
    }
}
