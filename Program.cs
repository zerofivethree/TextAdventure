/* Joseph Dye
 * 14 March 2014
 * 
 * HORSE SIMULATOR 2014
 * 
 * Logic:
 * Current = description of current scene
 * Player command will be sent to switch, which will run the appropriate function and set a new current
 * It will also set a numeric flag indicating the current scene.
 * This will be checked when interacting with the environment to ensure continuity.
 * 
 * I used the basic structure of an open-source text adventure I found online to help with some of the logic,
 * but everything else is MINE!
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
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 Joseph Dye presents");
            Console.WriteLine("             Joseph Dye's Horse Simulator 2014 ");
            Console.WriteLine("                a Joseph Dye game ");
            Console.ReadLine();
            Console.Clear();
            BeginGame();

        }

        public static void BeginGame()
        {
            Console.WriteLine("Basic commands: look, use, go, eat, call, argue, introspect.");
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