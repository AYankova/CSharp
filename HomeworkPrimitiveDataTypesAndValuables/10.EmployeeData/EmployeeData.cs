/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console.*/

using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Valentina";
            string secondName = "Petrova";
            byte age = 25;
            char gender = 'f';
            ulong personalID = 8306112507;
            uint employeeNum = 27569999;
            Console.WriteLine(firstName +" "+secondName+" "+age+" "+gender+" "+personalID+" "+employeeNum);


        }
    }
}
