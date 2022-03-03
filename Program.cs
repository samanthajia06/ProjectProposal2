namespace SSolomon_ProjectProposal2
{
    class program
    {
        static void Main(string[] args)
        {
        }

        /// <summary>
        /// Upon starting the game, the program must generate a word for the player to guess. 
        /// </summary>
        /// <returns>A random 5 letter word</returns>
        public static string GetRandomWord()
        {
            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <returns>the guess the user made</returns>
        public static string GetGuess(string correctWord)
        {
            return null;
        }

        public static void DisplayInfo(string guess, string correct)
        {
            // 1. Get random word
            // 2. Display number of letters in the word
            // 3. Prompt player to enter a guess
            
        }

        public static void DisplayCharInfo(char guess, int pos, string correct)
        {
            // 1. GetGuess
            // 2. display green if letter is in correct place 
            // 3. display yellow if the letter is in the word but not the correct place
            // 4. display white if the letter is not in the word at all
        }
    }
}