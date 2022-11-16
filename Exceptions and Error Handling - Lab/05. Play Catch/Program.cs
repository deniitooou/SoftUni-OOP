using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int exceptionCount = 0;

            while (exceptionCount < 3)
            {
                string[] command = Console.ReadLine().Split();

                try
                {
                    switch (command[0])
                    {
                        case "Replace": 
                            Replace(intOfIntegers, int.Parse(command[1]), int.Parse(command[2])); 
                            break;
                        case "Print": 
                            Print(intOfIntegers, int.Parse(command[1]), int.Parse(command[2])); 
                            break;
                        case "Show": 
                            Show(intOfIntegers, int.Parse(command[1])); 
                            break;
                    }
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }

                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCount++;
                }
            }

            Console.WriteLine(String.Join(", ", intOfIntegers));
        }

        static void Replace(int[] intOfIntegers, int index, int element)
        {
            intOfIntegers[index] = element; 
        }

        static void Print(int[] intOfIntegers, int start, int end)
        {
            Queue<int> intOfElements = new Queue<int>();

            for (int i = start; i <= end; i++)
            {
                intOfElements.Enqueue(intOfIntegers[i]);
            }
                Console.WriteLine(String.Join(", ", intOfElements));
        }

        static void Show(int[] intArray, int index)
        { 
            Console.WriteLine(intArray[index]);
        }
    }
}