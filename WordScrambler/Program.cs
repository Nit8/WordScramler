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
            bool continueWordUnscramble = true;
            do
            {
                Console.WriteLine("Please Enter the Option -M for Manual and F for File");
                var option=Console.ReadLine() ?? String.Empty;
                switch (option.ToUpper())
                {
                    case "F":
                        Console.WriteLine("Enter Scrambled Words File Name :");
                        ExecuteScrambledWordsInFileScenerio();
                        break;
                    case "M":
                        Console.WriteLine("Enter Scrambled Words Manually :");
                        ExecuteScrambledWordsManualScenerio();
                        break;
                    default:
                        Console.WriteLine("Option isnt recognized..");
                        break;
                }
                var continueWordunScrambleD = String.Empty;
                do
                {
                    Console.WriteLine("Do You want to continue?? Y/N ");
                    continueWordunScrambleD=(Console.ReadLine()?? String.Empty);
                } while (!continueWordunScrambleD.Equals("Y",StringComparison.OrdinalIgnoreCase) 
                        && !continueWordunScrambleD.Equals("N",StringComparison.OrdinalIgnoreCase));
                continueWordUnscramble = continueWordunScrambleD.Equals("Y", StringComparison.OrdinalIgnoreCase);
            } while (continueWordUnscramble);
        }

        private static void ExecuteScrambledWordsManualScenerio()
        {
        }

        private static void ExecuteScrambledWordsInFileScenerio()
        {
        }
    }
}
