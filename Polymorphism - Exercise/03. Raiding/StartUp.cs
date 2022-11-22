namespace Raiding
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Models;
    using Models.Contracts;

    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IHero> heroes = new List<IHero>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var nameOfHero = Console.ReadLine();
                var typeOfHero = Console.ReadLine();

                if (typeOfHero == nameof(Druid))
                {
                    heroes.Add(new Druid(nameOfHero));
                }

                else if (typeOfHero == nameof(Paladin))
                {
                    heroes.Add(new Paladin(nameOfHero));
                }

                else if (typeOfHero == nameof(Rogue))
                {
                    heroes.Add(new Rogue(nameOfHero));
                }

                else if (typeOfHero == nameof(Warrior))
                {
                    heroes.Add(new Warrior(nameOfHero));
                }

                else
                {
                    Console.WriteLine("Invalid hero!");
                    i--;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            foreach (var hero in heroes) Console.WriteLine(hero.CastAbility());

            if (heroes.Select(x => x.Power).Sum() >= bossPower)
            {
                Console.WriteLine("Victory!");
            }

            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}