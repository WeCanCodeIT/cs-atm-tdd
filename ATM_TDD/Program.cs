using System;

namespace ATM_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ATM Machine");

            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Check balance");
            Console.WriteLine("2. Withdraw $10");
            Console.WriteLine("3. Deposit $50");
            Console.WriteLine("4. Exit");

            string atmChoice = Console.ReadLine();
        }
    }
}
