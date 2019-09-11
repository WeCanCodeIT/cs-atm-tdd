using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_TDD
{
    public class ATM
    {
        public int Balance { get; set; }

        public ATM()
        {
            Balance = 200;
        }

        public ATM(int balance)
        {
            Balance = balance;
        }

        public void CheckBalance()
        {
            Console.WriteLine("Your balance is " + Balance);
        }
    }
}
