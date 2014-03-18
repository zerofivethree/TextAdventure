using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class acidTrip
    {
        /// <summary>
        /// This is a BAD ENDING.
        /// It presents a moral to the player of abstinence from substance abuse.
        /// It then dumps you back to the starting screen.
        /// </summary>
        public static void trip()
        {
            Console.Clear();
            Console.WriteLine("You have died from an overdose of SKETCHY ACID.");
            Console.WriteLine();
            Console.WriteLine("GAME OVER");
            Console.WriteLine();
            Console.WriteLine("Winners don't do drugs.");
            Console.ReadLine();
            Console.Clear();
            Program.Main(null);
        }
    }
}
