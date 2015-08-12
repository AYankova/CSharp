

using System;
using System.IO;

namespace _07.ReplaceSubstring
{
    class ReplaceSubstring
    {
        static void Main()
        {

            string input = GenerateLargeFile();
            string tempFile = @"..\..\start.txt";
            string search = "start";
            string replace = "finish";

            using (StreamReader read = new StreamReader(input))
            {
                using (StreamWriter write = new StreamWriter(tempFile, true))
                {
                    string line = read.ReadLine();
                    while (line != null)
                    {
                        write.WriteLine(line.Replace(search, replace));
                        line = read.ReadLine();
                    }
                }
            }
            File.Replace(tempFile, input, "backup.txt");
            //Delete back up file
            File.Delete("backup.txt");
            Console.WriteLine("Succes!You can find the file at: " + Path.GetFullPath("input.txt"));
        }

        static string GenerateLargeFile()
        {
            string fileName = @"..\..\input.txt";
            Random generator = new Random();

            StreamWriter writer = new StreamWriter(fileName, true);

            using (writer)
            {
                string[] words = { "start", "starter", "starting", "start-up", "start again", "bystart", "stop" };
                long fileSize = 0;
                long max = 1000;

                while (fileSize < max)
                {
                    string word = "";

                    for (int i = 0; i < 6; i++)
                    {
                        word += words[generator.Next(words.Length)] + " ";
                    }
                    writer.WriteLine(word);
                    FileInfo file = new FileInfo(fileName);
                    fileSize = file.Length;
                }
            }

            return fileName;

        }
    }
}
