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
                Console.WriteLine("3. Deposit $50.00");
                Console.WriteLine("4. Withdraw any amount");
                Console.WriteLine("5. Exit");

                string atmChoice = Console.ReadLine();

                switch (atmChoice)
                {
                    case "1":
                        double currentBalance = myAccount.CheckBalance();
                        Console.WriteLine($"Your current balance is ${currentBalance}");
                        break;
                    case "2":
                        if (myAccount.VerifySufficientFunds(10.00))
                        {
                            myAccount.Withdraw();
                            Console.WriteLine("You withdrew $10");
                        }
                        break;
                    case "3":
                        myAccount.Deposit();
                        Console.WriteLine("You deposited $50");
                        break;
                    case "4":
                        Console.Write("How much would you like to withdraw? ");
                        double withdrawalAmount = Convert.ToDouble(Console.ReadLine());
                        if (myAccount.VerifySufficientFunds(withdrawalAmount))
                        {
                            myAccount.Withdraw(withdrawalAmount);
                        }
                        break;
                    case "5":
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
