using System;

namespace ATM_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM(500);

            Console.WriteLine("Welcome to ATM Machine");

            bool inMenu = true;
            do
            {
                Console.WriteLine("\n\nWhat would you like to do?");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw $10");
                Console.WriteLine("3. Deposit $50");
                Console.WriteLine("4. Exit");

                string atmChoice = Console.ReadLine();

                switch (atmChoice)
                {
                    case "1":
                        Console.WriteLine("Checking balance....");
                        atm.CheckBalance();
                        break;

                    case "2":
                        Console.WriteLine("Withdrawing $10....");
                        break;

                    case "3":
                        Console.WriteLine("Depositing $50....");
                        break;

                    case "4":
                        Console.WriteLine("Good bye");
                        inMenu = false;
                        break;

                    default:
                        Console.WriteLine("Please type a valid choice");
                        break;
                }
            }while(inMenu);
        }
    }
}
