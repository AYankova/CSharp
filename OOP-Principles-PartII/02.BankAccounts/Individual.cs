namespace _02.BankAccounts
{
    using System;

    public class Individual:Customer
    {
        public Individual(string name, string address="Not available", string phoneNumber="Not available"):base(name,address,phoneNumber)
        {
            this.CustomerType = CustomerType.Individual;
        }
    }
}
