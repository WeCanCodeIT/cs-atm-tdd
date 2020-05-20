using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_TDD
{
    public class Account
    {
        public double Balance { get; set; }

        public Account()
        {
            Balance = 100.00;
        }

        public double CheckBalance()
        {
            return Balance;
        }

        public void Withdraw()
        {
            //if(Balance - 10.00 >= 0)
            //{
            //    Balance -= 10.00;
            //}
            //else
            //{
            //    Console.WriteLine("You do not have sufficient funds for this withdrawal");
            //}

            Balance -= 10.00;
        }

        public void Withdraw(double amount)
        {
            //if(Balance - amount >= 0)
            //{
            //    Balance = Balance - amount;
            //}
            //else
            //{
            //    Console.WriteLine("You do not have sufficient funds for this withdrawal");
            //}

            Balance = Balance - amount;
        }

        public void Deposit()
        {
            Balance += 50.00;
        }

        public bool VerifySufficientFunds(double amount)
        {
            if (Balance - amount >= 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"You do not have sufficient funds to withdraw {amount:C2}");
                return false;
            }
        }
    }
}
