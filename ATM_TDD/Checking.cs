using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_TDD
{
    public class Checking : Account
    {
        public double MinimumRequiredBalance { get; set; }
        public int CheckNumber { get; set; }

        public Checking()
        {
            MinimumRequiredBalance = 200.00;
            CheckNumber = 1;
        }

        public override void CheckBalance()
        {
            Console.Write($"My Checking Account, {NickName}: ");
            base.CheckBalance();
        }

        public override bool VerifySufficientFunds(double amount)
        {
            if (Balance - amount >= MinimumRequiredBalance)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"{NickName} does not have minimum required balance to withdraw {amount:C2}");
                return false;
            }
        }

        public void WriteCheck(double checkAmount)
        {
            Console.WriteLine($"Check Number: {CheckNumber} has been written in the amount of {checkAmount:C2}");
            CheckNumber++;
        }
    }
}
