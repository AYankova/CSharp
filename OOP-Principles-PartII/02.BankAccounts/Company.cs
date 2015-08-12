namespace _02.BankAccounts
{
    using System;

    public class Company:Customer
    {
        public Company(string name, string address="Not available", string phoneNumber="Not available"):base(name,address,phoneNumber)
        {
            this.CustomerType = CustomerType.Company;
        }
    }
}
