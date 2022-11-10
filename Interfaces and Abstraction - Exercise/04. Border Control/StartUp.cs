using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name, id, age;
            IIds entrity;
            var entrities = new List<IIds>();

            var command = Console.ReadLine();

            while (command != "End")
            {
                var token = command.Split();
                name = token[0];

                if (token.Length == 2)
                {
                    id = token[1];
                    entrity = new Robot(name, id);
                    entrities.Add(entrity);
                }

                else
                {
                    age = token[1];
                    id = token[2];

                    entrity = new Citizen(id, name, int.Parse(age));
                    entrities.Add(entrity);
                }

                command = Console.ReadLine();
            }

            string specifiedDigits = Console.ReadLine();
            entrities.RemoveAll(x => x.IsValidId(specifiedDigits));

            foreach (var entry in entrities)
            {
                Console.WriteLine(entry.Id);
            }
        }
    }
}

