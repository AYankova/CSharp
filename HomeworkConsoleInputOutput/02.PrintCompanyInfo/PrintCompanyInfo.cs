/*A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name,
age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.*/

using System;

namespace PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        static void Main()
        {
            Console.Write("Please input the company name: ");
            string nameCompany= Console.ReadLine();
            Console.Write("Please input the company address: ");
            string address = Console.ReadLine();
            Console.Write("Please input phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Please input fax number: ");
            string faxNumber= Console.ReadLine();
            Console.Write("Please input web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Please input manager's first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please input manager's last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Please input manager's age: ");
            string age = Console.ReadLine();
            Console.Write("Please input manager's phone: ");
            string phoneManager = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(nameCompany);
            Console.WriteLine("Address: "+ address);
            Console.WriteLine("Tel. "+ phoneNumber);
            Console.WriteLine("Fax. "+ faxNumber);
            Console.WriteLine("Web site: "+ webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})",firstName,lastName,age,phoneManager);
           

        }
    }
}
