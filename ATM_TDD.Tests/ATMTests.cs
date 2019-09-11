using System;
using Xunit;

namespace ATM_TDD.Tests
{
    public class ATMTests
    {
        // CheckBalance() should return balance of 200
        [Fact]
        public void CheckBalance_Should_Return_Balance_Of_200()
        {
            // Arrange
            ATM atm = new ATM();

            // Act
            atm.CheckBalance();

            // Assert
            Assert.Equal(200, atm.Balance);
        }

        // Withdrawal should reduce balance by 10 dollars

        // Deposit should increase balance by 50 dollars
    }
}
