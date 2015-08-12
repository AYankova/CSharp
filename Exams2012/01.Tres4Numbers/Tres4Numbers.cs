using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Tres4Numbers
{
    static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>
        {                           {0,"LON+"},	
                                    {1,"VK-"},
                                    {2, "*ACAD"},
                                    {3,"^MIM"},
                                    {4,"ERIK|"},	
                                    {5,"SEY&"},	
                                    {6,"EMY>>"},
                                    {7,"/TEL"},	
                                    {8,"<<DON"},	


        };
        ulong num = ulong.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        if (num == 0)
        {
            Console.WriteLine(dict[0]);
            Environment.Exit(0);
        };
        
        while (num >0)
        {
            int digit = (int)(num % 9);
            sb.Insert(0, dict[digit]);
            num = num / 9;
        }
            Console.WriteLine(sb);
  
    }
}

