namespace Person
{
    public class Person 
    {
        private int age;
        private string name;

        public Person(string Name, int Age)
        {
            name = Name;
            age = Age;
        }
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }
    }
}
