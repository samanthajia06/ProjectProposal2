using System;

namespace SSolomon_ProjectProposal2
{
    class TestDisplayInfo
    {
        public static void RunTest()
        {
            Console.WriteLine("Calling DisplayInfo(). This will test how accurate your word is.");

            Console.Write("You should see green letters except for a red 'c' and a yellow 'k'");
            program.DisplayInfo("snack", "snake");

            Console.Write("You should see green letters except for a white 'h'");
            program.DisplayInfo("white", "write");

            Console.Write("You should see green letters except for a red 'h', a yellow 'e', and white 'g', 'h', and 't'");
            program.DisplayInfo("height", "sprite");

        }
    }
}