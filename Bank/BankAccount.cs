using System;

namespace Bank
{
    public class BankAccount
    {
        private double balance;

        public BankAccount()
        {
        }

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public double Balance
        {
            get { return balance; }
        }

        public void AddMoney(double cash)
        {
            if (cash < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(cash));
            }

            balance += cash;
        }

        public void WithdrawMoney(double cash)
        {
            if (cash > balance)
            {
                throw new ArgumentOutOfRangeException(nameof(cash));
            }

            if (cash < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(cash));
            }

            balance -= cash;
        }

        public void TransferFundsTo(BankAccount otherAccount, double cash)
        {
            if (otherAccount is null)
            {
                throw new ArgumentNullException(nameof(otherAccount));
            }

            WithdrawMoney(cash);
            otherAccount.AddMoney(cash);
        }
    }
}
