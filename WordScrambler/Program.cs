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
        static void Main(string[] args)
        {
            try
            {
                bool continueWordUnscramble = true;
                do
                {
                    Console.WriteLine(Constants.OptionsOnHowToEnterScrambledWords);
                    var option = Console.ReadLine() ?? String.Empty;
                    switch (option.ToUpper())
                    {
                        case Constants.File:
                            Console.WriteLine(Constants.EnterScrambledWordsViaFile);
                            ExecuteScrambledWordsInFileScenerio();
                            break;
                        case Constants.Manual:
                            Console.WriteLine(Constants.EnterScrambledWordsManually);
                            ExecuteScrambledWordsManualScenerio();
                            break;
                        default:
                            Console.WriteLine(Constants.EnterScrambledWordsOptionNotRecognized);
                            break;
                    }
                    var continueWordunScrambleD = String.Empty;
                    do
                    {
                        Console.WriteLine(Constants.OptionsOnContinueTheProgram);
                        continueWordunScrambleD = (Console.ReadLine() ?? String.Empty);
                    } while (!continueWordunScrambleD.Equals(Constants.Yes, StringComparison.OrdinalIgnoreCase)
                            && !continueWordunScrambleD.Equals(Constants.No, StringComparison.OrdinalIgnoreCase));
                    continueWordUnscramble = continueWordunScrambleD.Equals(Constants.Yes, StringComparison.OrdinalIgnoreCase);
                } while (continueWordUnscramble);
            }
            catch (Exception ex)
            {

                Console.WriteLine(Constants.ErrorProgramWillBeTerminated + ex.Message);
            }
        }

        private static void ExecuteScrambledWordsManualScenerio()
        {
            var manualInp = Console.ReadLine() ?? String.Empty;
            string[] scrambledWords = manualInp.Split(',');
            DisplayMatchedUnscrambledWords(scrambledWords);

        }

        private static void ExecuteScrambledWordsInFileScenerio()
        {
            try
            {
                var filename = Console.ReadLine() ?? string.Empty;
                string[] scrambledWords = _fileReader.Read(filename);
                DisplayMatchedUnscrambledWords(scrambledWords);
            }
            catch (Exception ex)
            {
                Console.WriteLine(Constants.ErrorScrambledWordsCannotbeLoaded);
            }
            
        }
        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            string[] wordList = _fileReader.Read(Constants.WordListFileName);
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords,wordList);

            if (matchedWords.Any())
            {
                foreach(var matchedWord in matchedWords)
                {
                    Console.WriteLine(Constants.MatchFound,matchedWord.ScrambledWord,matchedWord.Word);
                }
            }
            else
            {
                Console.WriteLine(Constants.MatchNotFound);
            }

        }
    }
}
