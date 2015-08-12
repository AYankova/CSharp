namespace _02.BankAccounts
{
    using System;

    public abstract class BankAccount:IDepositable,IInterestCalculatable
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public BankAccount(Customer customer,decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        protected Customer Customer
        {
            get
            {
                return this.customer;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.customer = value;
            }
        }

        protected decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; } //I've personally had a negative balance in my bank account so I don't check if the value is negative:)
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate can't be negative!");
                }

                this.interestRate = value;
            }
        }

        public AccountType AccountType { get; protected set; }

        public virtual decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentException("Months cannot be a negative number!");
            }

            return this.InterestRate * months;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Cannot deposit a negative or zero amount of money!");
            }

            this.Balance += amount;
        }

        public override string ToString()
        {

            return string.Format("Account type: {0} \nBalance: {1} \nInterest rate per month: {2} \nCustomer:\n{3}",
                                    this.AccountType, this.Balance, this.InterestRate, this.Customer);
        }
    }
}
