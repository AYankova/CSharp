/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and
descriptive names.*/

using System;

namespace BankAccountNumber
{
    class BankAccountNumber
    {
        static void Main()
        {
            string firstName = "Valentina";
            string middleName = "Georgieva";
            string lastName = "Petrova";
            decimal balanceMoney = 1234657890000.589M;
            string bankName = "Societe Generale Express Bank";
            string IBAN = "BG65TTBB94001427318952";
            ulong creditCard1 = 1234567123456789u;
            ulong creditCard2 = 1234567123456798u;
            ulong creditCard3 = 1234567123456987u;
            Console.WriteLine("Account Holder-->"+ firstName + " " + middleName + " " + lastName +
                "\nMoney Balance-->" + balanceMoney + "\nBank-->" + bankName + "\nIBAN-->" + IBAN +
                "\nCredit Card 1-->" + creditCard1 + "\nCredit Card 2-->" + creditCard2 +
                "\nCredit Card 3-->" + creditCard3);
         }
    }
}
