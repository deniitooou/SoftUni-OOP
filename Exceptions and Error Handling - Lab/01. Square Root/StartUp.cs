using System;

namespace SquareRoot
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            try
            {
                if (num < 0)
                {
                    throw new ArgumentException("Invalid number.");
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(num));
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}