namespace WordScrambler
{
    class Constants
    {
        public const string OptionsOnHowToEnterScrambledWords = "Enter scrambled word(s) manually or as a file: F - file/ M - manual: ";
        public const string OptionsOnContinueTheProgram = "Would you Like to Continue? Y/N: ";
        public const string EnterScrambledWordsViaFile = "Enter full path including the file name: ";
        public const string EnterScrambledWordsManually = "Enter word(s) manually (comma seperated if multiple): ";

        public const string EnterScrambledWordsOptionNotRecognized = "The Option was not recognized...";
        public const string ErrorScrambledWordsCannotbeLoaded = "Scrambled Words were not Loaded because there was an error.";
        public const string ErrorProgramWillBeTerminated = "The Program will be Terminated...";

        public const string MatchFound = "Match found for {0}: {1}";
        public const string MatchNotFound = "No Match Found..";

        public const string Yes = "Y";
        public const string No = "N";
        public const string File = "F";
        public const string Manual = "M";

        public const string WordListFileName = "wordlist.txt";
    }
}
