namespace _02.BankAccounts
{
    using System;

    public class MortgageAccount:BankAccount
    {
        private const int DifferentInterestIndividualMonths = 6;
        private const int DifferentInterestCompanyMonths = 12;

        public MortgageAccount(Customer customer, decimal balance, decimal interestRate):base(customer,balance,interestRate)
        {
            this.AccountType = AccountType.Mortgage;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.CustomerType == CustomerType.Individual)
            {
                if (months <= DifferentInterestIndividualMonths)
                {
                    return 0.00m;
                }

                return this.InterestRate * (months - DifferentInterestIndividualMonths);
            }

            else if (this.Customer.CustomerType == CustomerType.Company)
            {
                if (months <= DifferentInterestCompanyMonths)
                {
                    return 0.00m;
                }

                return (this.InterestRate * DifferentInterestCompanyMonths) / 2 + this.InterestRate * (months - DifferentInterestCompanyMonths);
            }

            return 0.00m;
        }
    }
}
