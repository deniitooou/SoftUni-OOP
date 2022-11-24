namespace ValidationAttributes
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var person = new Person(null, 7);
            bool IsValidEntity = Validator.IsValid(person);

            Console.WriteLine(IsValidEntity);
        }
    }
}