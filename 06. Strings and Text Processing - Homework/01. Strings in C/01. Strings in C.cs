/*•	Describe the strings in C#.
  •	What is typical for the string data type?
  •	Describe the most important methods of the String class.*/

using System;

class StringsInC
{
    static void Main()
    {
        //Compare

        string a = "a";
        string b = "b";

        int c = string.Compare(a, b);
        Console.WriteLine(c);           //a is less than b=-1

        c = string.CompareOrdinal(b, a);
        Console.WriteLine(c);           //b is greater than a=1

        c = a.CompareTo(b);             //a is less than b=-1
        Console.WriteLine(c);

        c = b.CompareTo(a);             //b is greater than a=1
        Console.WriteLine(c);

        //Concat
        Console.WriteLine();
        string s1 = "time ";
        string s2 = "for ";
        string s3 = "some ";
        string s4 = "rest";
        string resultConcat = string.Concat(s1, s2, s3, s4);
        Console.WriteLine(resultConcat);            //time for some rest

        //Contains
        Console.WriteLine();
        string example1 = "dot net";
        string example2 = "Dot net";
        string example3 = "Dot Net";
        Console.WriteLine(example1.Contains("net"));  //True
        Console.WriteLine(example2.Contains("net"));  //True
        Console.WriteLine(example3.Contains("net"));  //False
        Console.WriteLine(example1.Contains("dot"));  //True
        Console.WriteLine(example2.Contains("dot"));  //False
        Console.WriteLine(example3.Contains("dot"));  //False

        //Copy
        Console.WriteLine();
        string value1 = "Literal";
        string value2 = string.Copy(value1);
        Console.WriteLine(value2);      //Literal

        //CopyTo
        Console.WriteLine();
        string val1 = "Telerik Academy";
        char[] array1 = new char[7];
        val1.CopyTo(8, array1, 0, 7);
        Console.WriteLine("--- Destination array ---");
        Console.WriteLine(array1.Length);       //7
        Console.WriteLine(array1);              //Academy

        //EndsWith
        Console.WriteLine();

        string someName = "http://telerikacademy.com";
        Console.WriteLine(someName.EndsWith("com"));       //True

        //Equals
        Console.WriteLine();

        string examp1 = "a" + 5;
        string examp2 = "a" + 5;
        string examp3 = "a" + 1;
        Console.WriteLine(examp1.Equals(examp2));   //True
        Console.WriteLine(examp1.Equals(examp3));   //False

        //Substring, IndexOf

        Console.WriteLine();

        string s = "I have a nasty scar";

        int i = 0;
        while ((i = s.IndexOf('a', i)) != -1)
        {                                                   //ave a nasty scar
            // Print out the substring.                     //a nasty scar
            Console.WriteLine(s.Substring(i));              //asty scar
            i++;                                            //ar
        }
        if (s.IndexOf("nasty") != -1)
        {
            Console.WriteLine("string contains nasty");    //string contains nasty
        }                        
        
        //Insert
        Console.WriteLine();

        string names2 = "Doncho and Niki and Ivo";
	    int index = names2.IndexOf("and ");
	    string trainers = names2.Insert(index + "and ".Length, "Evlogi and ");
        Console.WriteLine(trainers);            //Doncho and Evlogi and Niki and Ivo

        //Join

        Console.WriteLine();

        string[] array = { "Hi", "my", "friend","Johnny" };
        Console.WriteLine(string.Join(",", array));       //Hi,my,friend,Johnny

        //Length
        Console.WriteLine();

        string tmp = "";
        Console.WriteLine(tmp.Length);      //0
        Console.WriteLine("How's the weather?".Length);     //18

        //PadLeft, PadRight
        Console.WriteLine();

        string inpt1 = "sunny".PadRight(11);
        string inpt2 = "cloudy".PadLeft(11);
        Console.Write(inpt1);
        Console.WriteLine("not");           //sunny      not
        Console.WriteLine(inpt2);           //     cloudy    

        //Remove,Replace
        Console.WriteLine();

        string test1 = "012345666";
        string result1 = test1.Remove(6,2);
        Console.WriteLine(result1);         //0123456

        string some = "_::_ Nutella";
        Console.WriteLine(some);
        string output = some.Replace("_::_", "love");
        Console.WriteLine(output);          //love Nutella

        //Split
        Console.WriteLine();
        string someStr = "spent too much time on this task";
	    string[] words = someStr.Split(' ');
	    foreach (string word in words)
	    {
	    Console.WriteLine(word);
	    }

        //ToUpper,ToLower
        Console.WriteLine();

        string low1 = "Lowercase string.";
        string upper1 = low1.ToUpper();
        Console.WriteLine(upper1);              //LOWERCASE STRING
        Console.WriteLine(upper1.ToLower());    //lowercase string


        //Trim,TrimStart,TrimEnd
        Console.WriteLine();
        string st = " This is an example string.\r\n\r\n       ";       //[This is an example string.]

        Console.WriteLine("[{0}]",st);
        st = st.Trim();
        Console.WriteLine("[{0}]",st);

        string text = "\t,,,    again and again.";      
        char[] arrayTmp = new char[] { '\t', ',', ' ' }; 
        text = text.TrimStart(arrayTmp);
        Console.WriteLine(text);                            //again and again

        string[] items = new string[]
	    {
	    "Why so serious?!?",
	    "So long..."
	    };

        foreach (string item in items)
        {
            string trimmed = item.TrimEnd('?', '.', '!');       //Why so serious
            Console.WriteLine(item);                            //So long
            Console.WriteLine("--->" + trimmed);
        }

    }    
}
