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
            // Balance = Balance - 10.00;
            Balance -= 10.00;
        }
    }
}
