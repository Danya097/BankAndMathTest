namespace BankAccountApp
{
    public class BankAccount
    {
        public string AccountHolder { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountHolder, decimal initialBalance)
        {
            if (string.IsNullOrEmpty(accountHolder))
                throw new ArgumentException("Account holder cannot be empty");

            if (initialBalance < 0)
                throw new ArgumentException("Initial balance cannot be negative");

            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive");

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdrawal amount must be positive");

            if (amount > Balance)
                throw new InvalidOperationException("Insufficient funds");

            Balance -= amount;
        }
    }
}