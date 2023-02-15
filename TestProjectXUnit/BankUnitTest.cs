
using Bank;

namespace TestProjectXUnit
{
    public class BankUnitTest
    {
        [Fact]
        public void Adding_Funds()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT
            account.AddMoney(100);

            // ASSERT
            Assert.Equal(1100, account.Balance);
        }

        [Fact]
        public void Adding_Negative_Funds()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.AddMoney(-100));
        }

        [Fact]
        public void Withdrawing_Funds()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT
            account.WithdrawMoney(100);

            // ASSERT
            Assert.Equal(900, account.Balance);
        }

        [Fact]
        public void Withdrawing_Negative_Funds()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.WithdrawMoney(-100));
        }

        [Fact]
        public void Withdrawing_More_Than_Funds()
        {
            // ARRANGE
            var account = new BankAccount(1000);

            // ACT + ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => account.WithdrawMoney(2000));
        }

        [Fact]
        public void Transfering_Funds()
        {
            // ARRANGE
            var account = new BankAccount(1000);
            var otherAccount = new BankAccount();

            // ACT
            account.TransferFundsTo(otherAccount, 500);

            // ASSERT
            Assert.Equal(500, account.Balance);
            Assert.Equal(500, otherAccount.Balance);
        }

        
    }
}
