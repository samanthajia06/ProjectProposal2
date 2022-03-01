using System;

namespace SSolomon_ProjectProposal2
{
    class TestDisplayCharInfo
    {
        public static void RunTest()
        {
            Console.WriteLine("Calling DisplayCharInfo(). This will test each letter in each position to see how accurrate it is.");

            Console.Write("You should see a yellow 'c': ");
            program.DisplayCharInfo('c', 2, "combs");

            Console.Write("You should see a green 'c': ");
            program.DisplayCharInfo('c', 0, "combs");

            Console.Write("You should see a yellow 's': ");
            program.DisplayCharInfo('s', 3, "combs");

            Console.Write("You should see a green 's': ");
            program.DisplayCharInfo('s', 4, "combs");

        }
    }
}