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

        // Test that a new account has balance of 100
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
            //Arrange
            // Account object is instantiated in test constructor
            accountUnderTest.Balance = 50.00;

            //Act
            double myBalance = accountUnderTest.CheckBalance();

            //Assert
            Assert.Equal(accountUnderTest.Balance, myBalance);
        }

        // Test that Withdraw() method reduces balance by 10 dollars
        [Fact]
        public void Withdraw_Decreases_Balance_By_10()
        {
            //Arrange
            // Account object is instantiated in test constructor
            accountUnderTest.Balance = 50.00;
            var startingBalance = accountUnderTest.Balance;

            //Act
            accountUnderTest.Withdraw();

            //Assert
            Assert.Equal(startingBalance - 10, accountUnderTest.Balance);
        }

        // Test that Deposit() method increases balance by 50 dollars
        [Fact]
        public void Deposit_Increases_Balance_By_50()
        {
            //Arrange
            // Account object is instantiated in test constructor
            accountUnderTest.Balance = 50.00;
            var startingBalance = accountUnderTest.Balance;

            //Act
            accountUnderTest.Deposit();

            //Assert
            Assert.Equal(startingBalance + 50, accountUnderTest.Balance);
        }

        // Test that user cannot withdraw if funds are insufficient
        [Fact(Skip ="Refactored into another method")]
        public void Withdraw_10_Should_Be_Rejected_If_Creates_Negative_Balance()
        {
            // Arrange
            accountUnderTest.Balance = 5.00;

            // Act
            accountUnderTest.Withdraw();

            // Assert
            Assert.True(accountUnderTest.Balance >= 0);
        }

        // Test that user can withdraw given amount
        [Fact]
        public void Withdraw_Should_Decrease_Balance_By_Given_Amount()
        {
            // Arrange
            accountUnderTest.Balance = 100.00;
            double startingBalance = accountUnderTest.Balance;
            double withdrawalAmount = 17.50;

            // Act
            accountUnderTest.Withdraw(withdrawalAmount);

            // Assert
            Assert.Equal(startingBalance - withdrawalAmount, accountUnderTest.Balance);
        }

        // Test that user cannot withdraw a given amount if it creates a negative balance
        [Fact(Skip = "Refactored into another method")]
        public void Withdraw_of_Given_Amount_Should_Be_Rejected_If_Creates_Negative_Balance()
        {
            // Arrange
            accountUnderTest.Balance = 10.00;
            double withdrawalAmount = 50.00;

            // Act
            accountUnderTest.Withdraw(withdrawalAmount);

            // Assert
            Assert.True(accountUnderTest.Balance >= 0);
        }

        // Test that sufficient funds are available
        [Fact]
        public void VerifySufficientFunds_Should_Return_False_if_Inadequate_Funds_Available()
        {
            // Arrange
            accountUnderTest.Balance = 10.00;
            double withdrawalAmount = 50.00;

            // Act
            bool sufficientFunds = accountUnderTest.VerifySufficientFunds(withdrawalAmount);

            // Assert
            Assert.False(sufficientFunds);
        }
    }
}
