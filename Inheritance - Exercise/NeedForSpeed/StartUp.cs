namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar dodge = new SportCar(200, 70);
            dodge.Drive(4);
            System.Console.WriteLine(dodge.Fuel);

        }
    }
}
