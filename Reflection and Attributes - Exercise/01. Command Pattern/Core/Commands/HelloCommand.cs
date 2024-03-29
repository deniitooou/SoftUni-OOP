﻿namespace CommandPattern.Core.Commands
{
    using CommandPattern.Core.Contracts;

    public class HelloCommand : ICommand
    {
        public string Execute(string[] input) => $"Hello, {input[0]}";
    }
}