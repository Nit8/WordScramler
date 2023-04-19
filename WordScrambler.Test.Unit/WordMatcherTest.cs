﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WordScrambler.Workers;
namespace WordScrambler.Test.Unit
{

    [TestClass]
    public class WordMatcherTest
    {
        private readonly WordMatcher _wordMatcher = new WordMatcher();
        [TestMethod]
        public void ScrambledWordMatchesGivenWordIntheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] swords = { "omre" };
            var matchedWords = _wordMatcher.Match(swords, words);
            Assert.IsTrue(matchedWords.Count == 1);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
        }
        [TestMethod]
        public void ScrambledWordMatchesGivenWordsIntheList()
        {
            string[] words = { "cat", "chair", "more" };
            string[] swords = { "omre", "act" };
            var matchedWords = _wordMatcher.Match(swords, words);
            Assert.IsTrue(matchedWords.Count == 2);
            Assert.IsTrue(matchedWords[0].ScrambledWord.Equals("omre"));
            Assert.IsTrue(matchedWords[0].Word.Equals("more"));
            Assert.IsTrue(matchedWords[1].ScrambledWord.Equals("act"));
            Assert.IsTrue(matchedWords[1].Word.Equals("cat"));
        }
    }
}
