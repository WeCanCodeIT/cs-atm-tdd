using System;
using Xunit;

namespace ATM_TDD.Tests
{
    public class AccountTests
    {
        Account accountUnderTest;

        public AccountTests()
        {
            accountUnderTest = new Account();
        }

        // Test that a new account has balance of 0
        [Fact]
        public void New_Account_Should_Have_Balance_Of_100()
        {
            // Arrange
            // Account object is instantiated in test constructor

            // Act
            // The Account constructor sets the Account defaults upon instantiation

            // Assert
            Assert.Equal(100.00, accountUnderTest.Balance);
        }
        
        // Test that CheckBalance() method returns balance of 50
        [Fact]
        public void CheckBalance_Should_Return_Balance_Of_50()
        {
            ////Arrange
            //// Account object is instantiated in test constructor
            //accountUnderTest.Balance = 50.00;

            ////Act
            //double myBalance = accountUnderTest.CheckBalance();

            ////Assert
            //Assert.Equal(accountUnderTest.Balance, myBalance);
        }

        // Test that Withdraw() method reduces balance by 10 dollars
        [Fact]
        public void Withdraw_Decreases_Balance_By_10()
        {
            ////Arrange
            //// Account object is instantiated in test constructor
            //accountUnderTest.Balance = 50.00;
            //var startingBalance = accountUnderTest.Balance;

            ////Act
            //accountUnderTest.Withdraw();

            ////Assert
            //Assert.Equal(startingBalance - 10, accountUnderTest.Balance);
        }

        // Test that Deposit() method increases balance by 50 dollars
        [Fact]
        public void Deposit_Increases_Balance_By_50()
        {
            ////Arrange
            //// Account object is instantiated in test constructor
            //accountUnderTest.Balance = 50.00;
            //var startingBalance = accountUnderTest.Balance;

            ////Act
            //accountUnderTest.Deposit();

            ////Assert
            //Assert.Equal(startingBalance + 50, accountUnderTest.Balance);
        }



    }
}
