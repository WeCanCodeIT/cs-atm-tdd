using System;

namespace ATM_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            
            Console.WriteLine("Welcome to ATM Machine");

            bool continueBanking = true ;
            do
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw $10");
                Console.WriteLine("3. Deposit $50");
                Console.WriteLine("4. Exit");

                string atmChoice = Console.ReadLine();

                switch (atmChoice)
                {
                    case "1":
                        double currentBalance = myAccount.CheckBalance();
                        Console.WriteLine($"Your current balance is ${currentBalance}");
                        break;
                    case "2":
                        myAccount.Withdraw();
                        Console.WriteLine("You withdrew $10");
                        break;
                    case "3":
                        myAccount.Deposit();
                        Console.WriteLine("You deposited $50");
                        break;
                    case "4":
                        Console.WriteLine("Good-bye! Thanks for banking with us.");
                        continueBanking = false;
                        break;
                    default:
                        break;
                }
            } while (continueBanking);
        }
    }
}
