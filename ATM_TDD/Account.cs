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
            if(Balance - 10.00 >= 0)
            {
                Balance -= 10.00;
            }
            else
            {
                Console.WriteLine("You do not have sufficient funds for this withdrawal");
            }
        }

        public void Withdraw(double amount)
        {
            Balance = Balance - amount;
        }

        public void Deposit()
        {
            Balance += 50.00;
        }
    }
}
