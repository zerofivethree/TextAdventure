/* Joseph Dye
 * 17 March 2014
 * 
 * HORSE SIMULATOR 2014
 * 
 * I used the basic structure of an open-source text adventure I found online to help with some of the logic.
 * Horse ASCII art from http://www.asciiworld.com/-Horses-.html
 * Everything else is MINE!
 * 
 * KNOWN BUGS:
 * - Loading saved games is pretty buggy.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("     >>\\.");
            Console.WriteLine("    /_  )`.");
            Console.WriteLine("   /  _)`^)`.   _.---. _");
            Console.WriteLine("  (_,' \\  `^-)\"\"      `.\\");
            Console.WriteLine("        |              | \\");
            Console.WriteLine("        \\              / |");
            Console.WriteLine("       / \\  /.___.'\\  (\\ (_");
            Console.WriteLine("      < ,\"||     \\ |`. \\`-'");
            Console.WriteLine("       \\ ()      )|  )/");
            Console.WriteLine("       |_>|>     /_] //");
            Console.WriteLine("         /_]        /_]\");");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("             Horse Simulator 2014");
            Console.WriteLine("                by Joseph Dye");
            Console.ReadLine();
            Console.Clear();
            BeginGame();

        }

        public static void BeginGame()
        {
            Console.WriteLine("Basic commands: look, use, go, get, enter, eat, call, argue, introspect.");
            Console.WriteLine("Press enter to begin, type \"load\" to load a saved game, or type \"quit\" to quit");
            string beginGame = Console.ReadLine();
            beginGame = beginGame.ToLower();

            if (beginGame == "quit")
            {
                Console.Write("OK. Bye.");
            }
            else if (beginGame == "load")
            {
                fileIO.loadGame();
            }
            else
            {
                startingArea.grassyKnoll();
            }

        }
    }
}