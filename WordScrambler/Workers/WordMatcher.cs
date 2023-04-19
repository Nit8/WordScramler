using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordScrambler.Data;

namespace WordScrambler.Workers
{
    public class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            var matchedWords=new List<MatchedWord>();
            foreach (var sword in scrambledWords)
            {
                foreach (var word in wordList)
                {
                    if (sword.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(sword,word));

                    }
                    else
                    {
                        var scrambledWordArray = sword.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambledWordArray);
                        Array.Sort(wordArray);

                        var sortedsword=new String(scrambledWordArray);
                        var sortedword=new String(wordArray);

                        if (sortedsword.Equals(sortedword, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(sword, word));
                        }

                    }
                }
            }
            return matchedWords;
        }
        private MatchedWord BuildMatchedWord(string sword,string word)
        {
            MatchedWord matchedWord = new MatchedWord();
            matchedWord.ScrambledWord = sword;
            matchedWord.Word = word;
            return matchedWord;
        }
    }
}
