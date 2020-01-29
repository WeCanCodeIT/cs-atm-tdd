using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_TDD
{
    public class ATM
    {
        public double Balance { get; set; }

        public ATM()
        {
            Balance = 100.00;
        }

        public double CheckBalance()
        {
            return Balance;
        }

        public void Withdraw()
        {
            Balance -= 10;
            //Balance = Balance - 10;
        }

        public void Deposit()
        {
            Balance += 50;
        }
    }
}
