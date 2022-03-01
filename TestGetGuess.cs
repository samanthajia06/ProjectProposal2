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

            string result = program.GetGuess();

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

            string result = program.GetGuess();

            string expected2 = "apple";
            if (result != expected2)
            {
                Console.Error.WriteLine($"Failure: Expected result to be 'apple' but it was {result}");
                return false;
            }

            Console.WriteLine("Calling GetGuess(). This will test whether or not your guess is valid or not.");

            Console.WriteLine("Test that the program doesn't let you skip this step by just pressing enter. It should prompt you to enter another guess when you do this.");

            Console.WriteLine("Invalid Input! Only enter a word that is the exact amount of letters shown.");

            Console.WriteLine("Test that the program allows you to enter a word of the correct length. Enter 'tie'");

            string result = program.GetGuess();

            string expected3 = "tie";
            if (result != expected3)
            {
                Console.Error.WriteLine($"Failure: Expected result to be 'tie' but it was {result}");
                return false;
            }
        }
    }
}