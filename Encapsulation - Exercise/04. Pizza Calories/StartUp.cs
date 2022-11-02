using System;
using System.Linq;

namespace PizzaCaloriesss
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] pizzaName = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
            Pizza pizza;

            try
            {
                pizza = new Pizza(String.Join(" ", pizzaName));
            }
            catch (Exception name)
            {
                Console.WriteLine(name.Message);
                return;
            }

            string[] doughInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            try
            {
                var newDough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));
                pizza.Dough = newDough;
            }
            catch (Exception dough)
            {
                Console.WriteLine(dough.Message);
                return;
            }

            string toppingInfo;

            while ((toppingInfo = Console.ReadLine()) != "END")
            {
                string[] toppingTokens = toppingInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    Topping newTopping = new Topping(toppingTokens[1], int.Parse(toppingTokens[2]));
                    pizza.AddTopping(newTopping);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }

            Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
        }
    }
}