namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Bank
    {
        private string name;
        private List<BankAccount> accounts;

        public Bank(string name)
        {
            this.Name = name;
            this.accounts = new List<BankAccount>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Bank name must be specified!");
                }

                this.name = value;
            }
        }

        public BankAccount this[int index]
        {
            get { return this.accounts[index]; }
        }

        public void AddAccount(BankAccount account)
        {
            this.accounts.Add(account);
        }

        public void RemoveAccount(BankAccount account)
        {
            this.accounts.Remove(account);
        }

        public override string ToString()
        {
            this.accounts = this.accounts.OrderBy(acc => acc.AccountType).ToList();

            StringBuilder result = new StringBuilder();

            foreach (var acc in this.accounts)
            {
                result.AppendLine(acc.ToString());
                result.AppendLine();
            }

            return result.ToString().TrimEnd();
        }
    }
}
