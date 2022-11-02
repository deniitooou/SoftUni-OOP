using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            var lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                var data = Console.ReadLine().Split();
                Person p = new Person(data[0], data[1], int.Parse(data[2]), decimal.Parse(data[3]));
                persons.Add(p);
            }

            Team team = new Team("SoftUni");
            foreach (Person person in persons) team.AddPlayer(person);

            Console.WriteLine($"First team have {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team have {team.ReserveTeam.Count} players.");
        }
    }
}

