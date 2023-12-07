using ConsoleApp.Model;

namespace Accounts.UnitTests
{
    public class BankingAcountTests
    {
        // Method_Scenario_ExpectedBehavior

        [Fact]
        public void Income_ValidAmount_IncrementBalance()
        {
            // Arrange
            BankingAcount account = new BankingAcount("0000-1111");

            // Act
            account.Income(1);

            // Assert
            Assert.Equal(1, account.GetBalance());
        }

        [Fact]
        public void Withdraw_ValidAmount_DecrementBalance()
        {
            // Arrange
            BankingAcount account = new BankingAcount("0000-1111");
            account.Income(1);

            // Act
            account.Withdraw(1);

            // Assert
            Assert.Equal(0, account.GetBalance());
        }

        [Fact]
        public void Withdraw_AmountIsGreatherThanBalance_ShouldThrowInvalidOperationException() 
        {
            // Arrange
            BankingAcount account = new BankingAcount("0000-1111");
            account.Income(1);

            // Act
            Action act = () => account.Withdraw(2);

            // Assert
            Assert.Throws<InvalidOperationException>(act);
        }
    }
}