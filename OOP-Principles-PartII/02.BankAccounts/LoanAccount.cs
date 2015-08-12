namespace _02.BankAccounts
{
    using System;

    public class LoanAccount:BankAccount
    {
        private const int NoIntersetIndividualMonths = 3;
        private const int NoInterestCompanyMonths=2;

        public LoanAccount(Customer customer, decimal balance, decimal interestRate):base(customer, balance, interestRate)
        {
            this.AccountType = AccountType.Loan;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.CustomerType==CustomerType.Individual)
            {
                if (months <= NoIntersetIndividualMonths)
                {
                    return 0.00m;
                }

                return this.InterestRate * (months - NoIntersetIndividualMonths);
            }

            else if (this.Customer.CustomerType == CustomerType.Company)
            {
                if (months <= NoInterestCompanyMonths)
                {
                    return 0.00m;
                }

                return this.InterestRate * (months - NoInterestCompanyMonths);
            }

            return 0.00m;
        }
    }
}
