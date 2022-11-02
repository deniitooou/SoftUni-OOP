using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main()
        {
            List<Product> products = new List<Product>();
            List<Person> people = new List<Person>();

            try
            {
                people = ReadPeople();
                products = ReadProducts();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            string input = Console.ReadLine();
            while (input != "END")
            {
                var info = input.Split();
                string personName = info[0];
                string productName = info[1];

                var currentPerson = people.Find(x => x.Name == personName);
                var currentProduct = products.Find(x => x.Name == productName);

                if (currentPerson != null && currentProduct != null)
                    currentPerson.BuyProduct(currentProduct);

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.Products.Count > 0)
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products)}");
                else Console.WriteLine($"{person.Name} - Nothing bought");
            }
        }

        private static List<Person> ReadPeople()
        {
            List<Person> people = new List<Person>();

            string[] info = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < info.Length; i++)
            {
                string name = info[i].Split('=', StringSplitOptions.RemoveEmptyEntries).First();
                decimal money = decimal.Parse(info[i].Split('=', StringSplitOptions.RemoveEmptyEntries).Last());

                people.Add(new Person(name, money));
            }

            return people;
        }

        private static List<Product> ReadProducts()
        {
            List<Product> products = new List<Product>();

            string[] info = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < info.Length; i++)
            {
                string name = info[i].Split('=', StringSplitOptions.RemoveEmptyEntries).First();
                decimal cost = decimal.Parse(info[i].Split('=', StringSplitOptions.RemoveEmptyEntries).Last());

                products.Add(new Product(name, cost));
            }

            return products;
        }
    }
}