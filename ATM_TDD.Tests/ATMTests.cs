using System;
using Xunit;

namespace ATM_TDD.Tests
{
    public class ATMTests
    {
        // new account has balance of 0
        [Fact]
        public void New_ATM_Should_Have_Balance_100()
        {
            // Arrange
            ATM myAtm = new ATM();

            // Act

            // Assert
            Assert.Equal(100.00, myAtm.Balance);
        }
        
        // CheckBalance() should return balance of 200

        // Withdrawal should reduce balance by 10 dollars

        // Deposit should increase balance by 50 dollars
    }
}
