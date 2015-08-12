namespace _02.BankAccounts
{
    using System;

    class BankAccountsTest
    {
        static void Main()
        {
            Bank bank = new Bank("FIB");
            var peshoCompany = new Company("Hamali");
            var pesho = new Individual("Pesho");

            Console.WriteLine(peshoCompany is Company);  //True
            Console.WriteLine(peshoCompany is Customer); //True
            Console.WriteLine(pesho is Individual);      //True
            Console.WriteLine(pesho is Customer);        //True
            Console.WriteLine(pesho is Company);         //False

            Console.WriteLine(new string('-',50));

            BankAccount[] accounts=new BankAccount[]
            {
                new DepositAccount(peshoCompany , 1300.80m,3.25m),
                new LoanAccount(pesho, 5000m, 10.8m),
                new MortgageAccount(new Company("Gosho company"),1000.80m, 4.7m),
                new DepositAccount(new Individual("Vasko","Mladost 1, bl.153", "+359888777333"),120.3m,4.14m)
            };

            foreach (var acc in accounts)
            {
                bank.AddAccount(acc);
            }

            Console.WriteLine(bank);
            Console.WriteLine(new string('-', 50));

            try
            {
                foreach (var acc in accounts)
                {
                   acc.Deposit(200);
                   Console.WriteLine(acc);
                   Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e.Message);
            }

            try
            {
                foreach (var acc in accounts)
                {
                    acc.Deposit(-50);
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine(new string('-', 50));

            foreach (var acc in accounts)
            {
                Console.WriteLine(acc.CalculateInterest(6));
            }

            Console.WriteLine(new string('-', 50));

            var depositAcount = accounts[0] as DepositAccount;
            depositAcount.Withdraw(800);
            Console.WriteLine(depositAcount);

            Console.WriteLine(new string('-', 50));

            try
            {
                depositAcount.Withdraw(1000);
                Console.WriteLine(depositAcount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(new string('-', 50));
        }
    }
}
