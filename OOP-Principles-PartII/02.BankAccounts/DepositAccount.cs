namespace _02.BankAccounts
{
    using System;

    public class DepositAccount:BankAccount,IWithdrawable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate):base(customer,balance,interestRate)
        {
            this.AccountType = AccountType.Deposit;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > this.Balance)
            {
                throw new ArgumentException("There are less money in the deposit account than the sum you want to withdraw!");
            }
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be a negative number!");
            }

            if (this.Balance > 1000.00m )
            {
                return months * ((this.InterestRate / 100.00m) * this.Balance);
            }

            return 0.00m;
        }
    }
}
