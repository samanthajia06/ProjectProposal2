using System;
using System.Collections.Generic;

namespace SSolomon_ProjectProposal2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wordle!");
            string correctWord = GetRandomWord();
            Console.WriteLine("The random word is 5 characters long. Enter a random guess.");
            while (true)
            {
                string input = GetGuess(correctWord);
                if (input == correctWord)
                {
                    Console.WriteLine("Nice! You guessed the word correctly!");
                    return;
                }
                else
                {
                    DisplayInfo(input, correctWord);
                    Console.WriteLine("");
                }
            }

        }

        /// <summary>
        /// Upon starting the game, the program must generate a word for the player to guess. 
        /// </summary>
        /// <returns>A random 5 letter word</returns>
        public static string GetRandomWord()
        {
            List<string> words = new List<string>();
            words.Add("abuse");
            words.Add("adult");
            words.Add("agent");
            words.Add("anger");
            words.Add("apple");
            words.Add("award");
            words.Add("basis");
            words.Add("beach");
            words.Add("birth");
            words.Add("block");
            words.Add("blood");
            words.Add("board");
            words.Add("brain");
            words.Add("bread");
            words.Add("break");
            words.Add("brown");
            words.Add("buyer");
            words.Add("cause");
            words.Add("chain");
            words.Add("chair");
            words.Add("chest");
            words.Add("chief");
            words.Add("child");
            words.Add("china");
            words.Add("claim");
            words.Add("class");
            words.Add("clock");
            words.Add("coach");
            words.Add("coast");
            words.Add("court");
            words.Add("cover");
            words.Add("cream");
            words.Add("crime");
            words.Add("cross");
            words.Add("crowd");
            words.Add("crown");
            words.Add("cycle");
            words.Add("dance");
            words.Add("death");
            words.Add("depth");
            words.Add("doubt");
            words.Add("draft");
            words.Add("drama");
            words.Add("dream");
            words.Add("dress");
            words.Add("drink");
            words.Add("drive");
            words.Add("earth");
            words.Add("enemy");
            words.Add("entry");
            words.Add("error");
            words.Add("event");
            words.Add("faith");
            words.Add("fault");
            words.Add("field");
            words.Add("fight");
            words.Add("final");
            words.Add("floor");
            words.Add("focus");
            words.Add("force");
            words.Add("frame");
            words.Add("frank");
            words.Add("front");
            words.Add("fruit");
            words.Add("glass");
            words.Add("grass");
            words.Add("green");
            words.Add("group");
            words.Add("guide");
            words.Add("heart");
            words.Add("Horse");
            words.Add("hotel");
            words.Add("house");
            words.Add("image");
            words.Add("index");
            words.Add("input");
            words.Add("issue");
            words.Add("japan");
            words.Add("jones");
            words.Add("judge");
            words.Add("knife");
            words.Add("layer");
            words.Add("level");
            words.Add("light");
            words.Add("limit");
            words.Add("lunch");
            words.Add("major");
            words.Add("march");
            words.Add("match");
            words.Add("metal");
            words.Add("model");
            words.Add("money");
            words.Add("month");
            words.Add("motor");
            words.Add("mouth");
            words.Add("music");
            words.Add("night");
            words.Add("noise");
            words.Add("north");
            words.Add("novel");
            words.Add("nurse");
            words.Add("offer");
            words.Add("order");
            words.Add("other");
            words.Add("owner");
            words.Add("panel");
            words.Add("paper");
            words.Add("party");
            words.Add("peace");
            words.Add("phase");
            words.Add("phone");
            words.Add("piece");
            words.Add("pilot");
            words.Add("pitch");
            words.Add("place");
            words.Add("plane");
            words.Add("plant");
            words.Add("plate");
            words.Add("point");
            words.Add("pound");
            words.Add("power");
            words.Add("press");
            words.Add("price");
            words.Add("pride");
            words.Add("prize");
            words.Add("proof");
            words.Add("queen");
            words.Add("radio");
            words.Add("range");
            words.Add("ratio");
            words.Add("reply");
            words.Add("right");
            words.Add("river");
            words.Add("round");
            words.Add("route");
            words.Add("rugby");
            words.Add("scale");
            words.Add("scene");
            words.Add("scope");
            words.Add("score");
            words.Add("sense");
            words.Add("shape");
            words.Add("share");
            words.Add("sheep");
            words.Add("sheet");
            words.Add("shift");
            words.Add("shirt");
            words.Add("shock");
            words.Add("sight");
            words.Add("simon");
            words.Add("skill");
            words.Add("sleep");
            words.Add("smile");
            words.Add("smith");
            words.Add("smoke");
            words.Add("sound");
            words.Add("south");
            words.Add("space");
            words.Add("speed");
            words.Add("spite");
            words.Add("sport");
            words.Add("squad");
            words.Add("staff");
            words.Add("stage");
            words.Add("start");
            words.Add("state");
            words.Add("steam");
            words.Add("steel");
            words.Add("stock");
            words.Add("stone");
            words.Add("store");
            words.Add("study");
            words.Add("stuff");
            words.Add("style");
            words.Add("sugar");
            words.Add("table");
            words.Add("taste");
            words.Add("theme");
            words.Add("thing");
            words.Add("title");
            words.Add("total");
            words.Add("touch");
            words.Add("tower");
            words.Add("track");
            words.Add("trade");
            words.Add("train");
            words.Add("trend");
            words.Add("trial");
            words.Add("trust");
            words.Add("truth");
            words.Add("uncle");
            words.Add("union");
            words.Add("unity");
            words.Add("value");
            words.Add("video");
            words.Add("visit");
            words.Add("voice");
            words.Add("waste");
            words.Add("watch");
            words.Add("water");
            words.Add("while");
            words.Add("white");
            words.Add("whole");
            words.Add("woman");
            words.Add("world");
            words.Add("youth");

            Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string randomWord = words[index];

            // program.loadfile(words.txt);


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
            while (true)
            {
                Console.WriteLine("Try to guess the word by entering a 5 letter word.");
                string input = Console.ReadLine();
                if (input.Length == correctWord.Length)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Your guess must only be 5 characters long.");
                }
            }
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
            Console.ForegroundColor = ConsoleColor.Black;

            // 1. GetGuess
            // 2. display green if letter is in correct place 
            // 3. display yellow if the letter is in the word but not the correct place
            // 4. display white if the letter is not in the word at all
        }
    }
}