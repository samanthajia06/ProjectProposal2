using System;
using System.Collections.Generic;

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
            List<string> names = new List<string>();
            names.Add("earth");

            Random generator = new Random();
            int index = generator.Next(0, names.Count);

            string randomWord = names[ix];

            // program.loadfile(words.txt);

            //TODO: Similar to https://jcollard.github.io/IntroToCSharpSite/examples/random-dog-generator

            // 1. Load a filed called `words.txt`
            // 2. Store each line as a separate word in a list named `words`
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return randomWord;
        }

        /// <summary>
        /// Prompts user to enter a word, then reads the word and validates the length of the word.
        /// </summary>
        /// <param name="correctWord"></param>
        /// <returns>the guess the user made</returns>
        public static string GetGuess(string correctWord)
        {
            int playerGuess;

            do
            {
                Console.WriteLine("Try to guess the word by entering a 5 letter word.");
                string input = Console.ReadLine();
                if (playerGuess == correctWord)
                {
                    Console.WriteLine("Nice! You got the word first try!");
                }
                else
                {
                    
                }
            }
            // TODO: look at Console Guessing Game

            return null;
        }
        /// <summary>
        /// Reads the word and displays the accuracy of the overall word. 
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="correct"></param>
        public static void DisplayInfo(string guess, string correct)
        {
            if (guess.Length != correct.Length)
            {
                throw new Exception($"Expected {guess} and {correct} to have the same length.");
            }

            int ix = 0;
         
            while (ix < correct.Length)
            {
                char guessChar = guess[ix];
                char correctChar = correct[ix];

                DisplayCharInfo(guessChar, ix, correct);
                ix = ix + 1;

            }

            // 1. Get random word
            // 2. Display number of letters in the word
            // 3. Prompt player to enter a guess

            return;

        }
        /// <summary>
        /// Reads each letter and displays green, yellow, and white to show the user which letters are correct, in the wrong place, or not in the word. 
        /// </summary>
        /// <param name="guess"></param>
        /// <param name="pos"></param>
        /// <param name="correct"></param>
        public static void DisplayCharInfo(char guess, int pos, string correct)
        {

            if (guess == correct[pos])
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (correct.Contains(guess))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.Write(guess);
            Console.ForegroundColor = ConsoleColor.White;

            // 1. GetGuess
            // 2. display green if letter is in correct place 
            // 3. display yellow if the letter is in the word but not the correct place
            // 4. display white if the letter is not in the word at all
        }
    }
}