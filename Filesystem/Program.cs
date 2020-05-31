using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Filesystem
{
    class Program
    {
        static void Main(string[] args)
        {
          
            string filepath = @"C:\Users\Purplepetite\source\repos\Filesystem\sampleFile.txt";
            string filepath1 = @"C:\Users\Purplepetite\source\repos\Filesystem\sampleFile1.txt";
            Console.WriteLine(File.Exists(filepath) ? "File exists." : "File does not exist.");

            string[] lines = File.ReadAllLines(filepath).ToArray();

            using (StreamWriter outputFile = new StreamWriter(filepath1))
            {
                //foreach (string line in lines)
                //    outputFile.WriteLine(line);
              
                // Parallel equivalent
                Parallel.ForEach(lines, line => outputFile.WriteLine(line));
            }




            Console.WriteLine("Hello World!");
        }
    }
}
