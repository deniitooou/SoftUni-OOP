using System;
using System.Collections.Generic;
using System.Linq;

namespace EnterNumbers
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<int> numsCollection = new List<int>();

            while (numsCollection.Count < 10)
            {
                try
                {
                    if (!numsCollection.Any())
                    {
                        numsCollection.Add(ReadNumber(1, 100));
                    }

                    else
                    {
                        numsCollection.Add(ReadNumber(numsCollection.Max(), 100));
                    }
                }

                catch (FormatException formatEx)
                {
                    Console.WriteLine(formatEx.Message);
                }

                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }

            Console.WriteLine(String.Join(", ", numsCollection));
        }

        static int ReadNumber(int start, int end)
        {
            string input = Console.ReadLine();
            int number;

            try
            {
                number = int.Parse(input);
            }

            catch (FormatException)
            {
                throw new FormatException("Invalid Number!");
            }

            if (number <= start || number >= end)
            {
                throw new ArgumentException($"Your number is not in range {start} - {end}!");
            }

            return number;
        }
    }
}