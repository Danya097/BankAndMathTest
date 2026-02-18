using Xunit;
using BankAccountApp;

namespace BankAccountApp.Tests
{
    public class BankAccountTests
    {
        [Fact]
        public void CreatingAccount_WithValidData_ShouldSetProperties()
        {
            var account = new BankAccount("Dan", 100);
            Assert.Equal("Dan", account.AccountHolder);
            Assert.Equal(100, account.Balance);
        }

        [Fact]
        public void CreatingAccount_WithNegativeBalance_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => new BankAccount("Dan", -50));
        }

        [Fact]
        public void Deposit_PositiveAmount_ShouldIncreaseBalance()
        {
            var account = new BankAccount("Dan", 100);
            account.Deposit(50);
            Assert.Equal(150, account.Balance);
        }

        [Fact]
        public void Deposit_NegativeAmount_ShouldThrow()
        {
            var account = new BankAccount("Dan", 100);
            Assert.Throws<ArgumentException>(() => account.Deposit(-50));
        }

        [Fact]
        public void Withdraw_ValidAmount_ShouldDecreaseBalance()
        {
            var account = new BankAccount("Dan", 100);
            account.Withdraw(30);
            Assert.Equal(70, account.Balance);
        }

        [Fact]
        public void Withdraw_TooMuch_ShouldThrow()
        {
            var account = new BankAccount("Dan", 100);
            Assert.Throws<InvalidOperationException>(() => account.Withdraw(150));
        }

        [Fact]
        public void Withdraw_NegativeAmount_ShouldThrow()
        {
            var account = new BankAccount("Dan", 100);
            Assert.Throws<ArgumentException>(() => account.Withdraw(-20));
        }

        [Fact]
        public void AccountHolder_CannotBeEmpty_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => new BankAccount("", 100));
        }
    }
}