namespace SSolomon_ProjectProposal2
{
    class program
    {
        static void Main(string[] args)
        {

            /// <summary>
            /// Upon starting the game, the program must generate a word for the player to guess. 
            /// </summary>
            /// <returns></returns>
            public static string GetRandomWord()
            {
                // 1. Load a filed called `words.txt`
                // 2. Store each line as a separate word in a list named `words`
                // 3. Generate a random number between 0 and `words.Count` and store the result in
                //    a variable called `ix`
                // 4. Return the word at position `ix`. (e.g. `words[ix]`)
                return null;
            }
        }

        string GetGuess(string correct word);

        void DisplayInfo()
        {
            // 1. Get random word
            // 2. Display number of letters in the word
            // 3. Prompt player to enter a guess
            return void;
        }

        void DisplayCharInfo()
        {
            // 1. GetGuess
            // 2. display green if letter is in correct place 
            // 3. display yellow if the letter is in the word but not the correct place
            // 4. display white if the letter is not in the word at all
            return void;
        }
    }
}