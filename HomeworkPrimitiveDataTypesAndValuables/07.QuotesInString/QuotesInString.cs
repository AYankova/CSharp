/*Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.*/

using System;

namespace QuotesInString
{
    class QuotesInString
    {
        static void Main()
        {
            string varUseQuote = "The \"use\" of quotations causes difficulties.";
            string varWithoutQuotesEscape =@"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(varUseQuote);
            Console.WriteLine(varWithoutQuotesEscape);
        }
    }
}
