using System;

namespace SSolomon_ProjectProposal2
{
    class TestGetGuess
    {
        public static bool RunTest()
        {
            Console.WriteLine("Calling GetGuess(). This will test whether or not your guess is valid or not.");

            Console.WriteLine("Test that the program doesn't let you skip this step by just pressing enter. It should prompt you to enter another guess when you do this.");

            Console.WriteLine("Invalid Input! Only enter a word that is the exact amount of letters shown.");

            Console.WriteLine("Test that the program allows you to enter a word of the correct length. Enter 'water'");

            string result = program.GetGuess("chard");

            string expected = "water";

            if (result != expected)
            {
                Console.Error.WriteLine($"Failure: Expected result to be 'water' but it was {result}");
                return false;
            }

            Console.WriteLine("Calling GetGuess(). This will test whether or not your guess is valid or not.");

            Console.WriteLine("Test that the program doesn't let you skip this step by just pressing enter. It should prompt you to enter another guess when you do this.");

            Console.WriteLine("Invalid Input! Only enter a word that is the exact amount of letters shown.");

            Console.WriteLine("Test that the program allows you to enter a word of the correct length. Enter 'apple'");

            result = program.GetGuess("chase");

            string expected2 = "apple";
            if (result != expected2)
            {
                Console.Error.WriteLine($"Failure: Expected result to be 'apple' but it was {result}");
                return false;
            }

            Console.WriteLine("Calling GetGuess(). This will test whether or not your guess is valid or not.");

            Console.WriteLine("Test that the program doesn't let you skip this step by just pressing enter. It should prompt you to enter another guess when you do this.");

            Console.WriteLine("Invalid Input! Only enter a word that is the exact amount of letters shown.");

            Console.WriteLine("Test that the program allows you to enter a word of the correct length. Enter 'white'");

            result = program.GetGuess("green");

            string expected3 = "white";
            if (result != expected3)
            {
                Console.Error.WriteLine($"Failure: Expected result to be 'white' but it was {result}");
                return false;
            }

            return true;
        }
    }
}