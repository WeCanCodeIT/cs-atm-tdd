using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_TDD
{
    public class Account
    {
        public double Balance { get; set; }
        public string AccountNumber { get; set; }
        public string NickName { get; set; }

        public Account()
        {
            Balance = 100.00;
        }

        public virtual void CheckBalance()
        {
            Console.WriteLine($"Current balance is ${Balance}");
        }

        public void Withdraw()
        {
            Balance -= 10.00;
        }

        public void Withdraw(double amount)
        {
            Balance = Balance - amount;
            Console.WriteLine($"{amount:C2} was withdrawn from {NickName}");
        }

        public void Deposit()
        {
            Balance += 50.00;
        }

        public virtual bool VerifySufficientFunds(double amount)
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
