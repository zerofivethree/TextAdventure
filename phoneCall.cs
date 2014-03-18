using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class phoneCall
    {
        /// <summary>
        /// The TRUE END where you become a famous rock star on ROLLING STONE's cover
        /// </summary>
        public static void goodEnding()
        {
            Console.Clear();
            Console.WriteLine("You call ROLLING STONE MAGAZINE to find that they want you");
            Console.WriteLine("to be on the cover of their next issue.");
            Console.WriteLine();
            Console.WriteLine("What's more, you're going to get interviewed by none other than");
            Console.WriteLine("HORSE DAVID BYRNE.");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("Wow! You guess dreams do come true!");
            Console.WriteLine();
            Console.ReadLine();
            Console.WriteLine("GAME OVER.");
            Console.WriteLine("GOOD ENDING / TRUE ENDING.");
            Console.ReadLine();
            Console.Clear();
            Program.Main(null);
        }
    }
}
