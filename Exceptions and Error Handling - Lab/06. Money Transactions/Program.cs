using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MoneyTransactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accountBalance = new Dictionary<int, double>();

            string[] tokens = Console.ReadLine().Split(',');

            for (int i = 0; i < tokens.Length; i++)
            {
                int account = int.Parse(tokens[i].Split('-').First());
                double balance = double.Parse(tokens[i].Split('-').Last());
                accountBalance.Add(account, balance);
            }

            string inputCommands;
            while ((inputCommands = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] command = inputCommands.Split();
                    string commands = command[0];

                    if (commands != "Deposit" && commands != "Withdraw")
                    {
                        throw new ArgumentException("Invalid command!");
                    }

                    int account;

                    try
                    {
                        account = int.Parse(command[1]);
                        if (!accountBalance.Keys.Contains(account))
                        {
                            throw new FormatException();
                        }
                    }

                    catch (FormatException)
                    { 
                        throw new ArgumentException("Invalid account!"); 
                    }

                    double money = double.Parse(command[2]);

                    if (commands == "Deposit")
                    {
                        accountBalance[account] += money;
                    }

                    else if (commands == "Withdraw")
                    {
                        if (money > accountBalance[account])
                        {
                            throw new ArgumentException("Insufficient balance!");
                        }

                        accountBalance[account] -= money;
                    }

                    Console.WriteLine($"Account {account} has new balance: {accountBalance[account]:f2}");
                }
                catch (ArgumentException ex)
                { 
                    Console.WriteLine(ex.Message); 
                }

                Console.WriteLine("Enter another command");
            }
        }
    }
}   