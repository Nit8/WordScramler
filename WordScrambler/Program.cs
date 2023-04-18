using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


//READ AND WRITE A FILE
namespace WordScrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "This is the first line", "This is a second line", "This is a third line" };
            File.WriteAllLines("MyFile.txt", lines);
            string[] fileContent = File.ReadAllLines("./MyFile.txt");
            Console.WriteLine(fileContent[0]);
        }
    }
}
