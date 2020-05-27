using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_TDD
{
    public class Savings : Account
    {
        public double InterestRate { get; set; }

        public Savings()
        {
            Balance = 200.00;
        }

        public override void CheckBalance()
        {
            Console.Write($"My Savings Account, {NickName}: ");
            base.CheckBalance();
        }
    }
}
