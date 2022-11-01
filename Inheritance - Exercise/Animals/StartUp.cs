using System;
using System.Linq;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();

            string command = Console.ReadLine();

            while (command != "Beast!")
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string gender = string.Empty;

                if (tokens.Length > 2)
                {
                    gender = tokens[2];
                }

                if (command == "Dog)")
                {
                        Dog dog = new Dog(name, age, gender);
                        result.Append(dog.ToString());
                }
                else if (command == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    result.Append(cat.ToString());
                }
                else if (command == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    result.Append(frog.ToString());
                }
                else if (command == "Kittens")
                {
                    Kitten kitten = new Kitten(name, age);
                    result.Append(kitten.ToString());
                }
                else if (command == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    result.Append(tomcat.ToString());
                }

                else
                {
                    throw new Exception("Invalid input!");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(result.ToString());
        }
    }
}
