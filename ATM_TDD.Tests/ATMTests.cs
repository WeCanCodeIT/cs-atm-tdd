using System;
using Xunit;

namespace ATM_TDD.Tests
{
    public class ATMTests
    {
        ATM myAtm;

        public ATMTests()
        {
            myAtm = new ATM();
        }

        // new account has balance of 0
        [Fact]
        public void New_ATM_Should_Have_Balance_100()
        {
            // Arrange
            // ATM myAtm = new ATM();

            // Act

            // Assert
            Assert.Equal(100.00, myAtm.Balance);
        }
        
        // CheckBalance() should return balance of 50
        [Fact]
        public void CheckBalance_Check_Our_Balance()
        {
            //Arrange
            // ATM myAtm = new ATM();
            myAtm.Balance = 50.00;

            //Act
            double myBalance = myAtm.CheckBalance();

            //Assert
            Assert.Equal(myAtm.Balance, myBalance);
        }

        // Withdrawal should reduce balance by 10 dollars
        [Fact]
        public void Withdraw_Decreases_Balance_By_10()
        {
            //Arrange
            // ATM myAtm = new ATM();
            myAtm.Balance = 50.00;
            var startingBalance = myAtm.Balance;

            //Act
            myAtm.Withdraw();

            //Assert
            Assert.Equal(startingBalance-10, myAtm.Balance);
        }

        // Deposit should increase balance by 50 dollars
        [Fact]
        public void Deposit_Increases_Balance_By_50()
        {
            //Arrange
            // ATM myAtm = new ATM();
            myAtm.Balance = 50.00;
            var startingBalance = myAtm.Balance;

            //Act
            myAtm.Deposit();

            //Assert
            Assert.Equal(startingBalance + 50, myAtm.Balance);
        }



    }
}
