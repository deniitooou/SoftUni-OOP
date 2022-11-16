using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfIntegers
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int currSum = 0;
            string input = Console.ReadLine();

            Queue<string> queOfElements = new Queue<string>(input.Split());

            while (queOfElements.Any())
            {
                int num = 0;
                string element = queOfElements.Dequeue();

                try
                { 
                    num = int.Parse(element); 
                }

                catch (FormatException)
                { 
                    Console.WriteLine($"The element '{element}' is in wrong format!"); 
                }

                catch (OverflowException)
                { 
                    Console.WriteLine($"The element '{element}' is out of range!"); 
                }

                currSum += num;
                Console.WriteLine($"Element '{element}' processed - current sum: {currSum}");
            }

            Console.WriteLine($"The total sum of all integers is: {currSum}");
        }
    }
}