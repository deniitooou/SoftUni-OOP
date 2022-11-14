namespace MilitaryElite.IO
{
    using System;

    using MilitaryElite.IO.Interfaces;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
            => Console.ReadLine();
    }
}
