//•	Write a program that reads a text file and inserts line numbers in front of each of its lines.
//•	The result should be written to another text file.

using System.Text;
using System;
using System.IO;

class LineNumbers
{
    static void MakeTestFile(string file)
    {
        StreamWriter writer = null;
        try
        {
            writer = new StreamWriter(file + ".txt");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        using (writer)
        {
            writer.WriteLine("The Information Technology Association of America (ITAA) explains'information technology' \n as encompassing all possible aspects of information systems based on computers.Both software development \n and the hardware involved in the IT industry include everything from computer systems, to the design, \n implementation, study and development of IT and management systems.Owing to its easy accessibility and \n the wide range of IT   products available, the demand for IT services has increased substantially over the \n years.The IT sector has   emerged as a major global source of both growth and employment.");
        }
    }
    static void Main()
    {
        try
        {
            MakeTestFile("TestFile");
            StreamReader reader = new StreamReader("TestFile.txt");
            StreamWriter writer = new StreamWriter("Result.txt");

            string read;
            int line = 1;
          
                using (reader)
                using (writer)
                {
                    while ((read=reader.ReadLine()) != null)
                    {
                        writer.WriteLine("{0,2} {1}", line, read);
                        ++line;
                    }
                }
        }
        
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        Console.WriteLine("Task completed!");
        Console.WriteLine("You can find the file in " + Path.GetFullPath("Result.txt"));
    }
}

