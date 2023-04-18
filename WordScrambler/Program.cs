using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WordScrambler.Workers;
using WordScrambler.Data;


//READ AND WRITE A FILE
namespace WordScrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        private const string wordlistfilename = "wordList.txt";
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
            var manualInp = Console.ReadLine() ?? String.Empty;
            string[] scrambledWords = manualInp.Split(',');
            DisplayMatchedUnscrambledWords(scrambledWords);

        }

        private static void ExecuteScrambledWordsInFileScenerio()
        {
            var filename=Console.ReadLine()?? string.Empty;
            string[] scrambledWords = _fileReader.Read(filename);
        }
        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            string[] wordList = _fileReader.Read(wordlistfilename);
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords,wordList);

            if (matchedWords.Any())
            {
                foreach(var matchedWord in matchedWords)
                {
                    Console.WriteLine("Match found for {0}:{1}", matchedWord.ScrambledWord, matchedWord.Word);
                }
            }

        }
    }
}
