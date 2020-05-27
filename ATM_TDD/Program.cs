using System;
using System.Collections.Generic;

namespace ATM_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            List<Account> ListOfAccounts = new List<Account>();
            Checking checkingAccount = new Checking()
            {
                AccountNumber = "12354",
                NickName = "First Checking"
            };

            ListOfAccounts.Add(checkingAccount); 

            ListOfAccounts.Add(new Savings()
            { 
                AccountNumber = "S09843",
                NickName = "Goal Savings"
            });


            Console.WriteLine("Welcome to ATM Machine");

            bool continueBanking = true ;
            do
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw $10");
                Console.WriteLine("3. Deposit $50.00");
                Console.WriteLine("4. Withdraw any amount");
                Console.WriteLine("5. Show my accounts");
                Console.WriteLine("6. Write a check");
                Console.WriteLine("7. Exit");

                string atmChoice = Console.ReadLine();

                switch (atmChoice)
                {
                    case "1":
                        foreach(Account account in ListOfAccounts)
                        {
                            account.CheckBalance();
                        }
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
                        foreach(Account account in ListOfAccounts)
                        {
                            if (account.VerifySufficientFunds(withdrawalAmount))
                            {
                                account.Withdraw(withdrawalAmount);
                            }
                        }
                        break;
                    case "5":
                        foreach (Account account in ListOfAccounts)
                        {
                            Console.WriteLine($"{account.NickName} {account.Balance:C2}");
                        }
                        break;
                    case "6":
                        Console.Write("How much would you like to write check for? ");
                        double checkAmount = Convert.ToDouble(Console.ReadLine());
                        checkingAccount.WriteCheck(checkAmount);
                        break;
                    case "7":
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
