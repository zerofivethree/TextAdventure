using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextAdventure
{
    class fileIO
    {
        /* Here we will store methods for saving and loading the game.
         * How we will do that:
         * 1. Compile the flag variables into a collection.
         * 2. Write to text file, along with current area.
         * 3. Write resume script to dump you back to current area with flag progress.
         * 4. Done.
         */
        
        public static void saveGame(int area, Dictionary<int, bool> gameInfo)
        {
            Dictionary<int, bool> gameDictSave = new Dictionary<int, bool>();
            StreamWriter sw = new StreamWriter(@"C:\\HorseSim.txt", false);
            sw.WriteLine(area);
            foreach(KeyValuePair<int, bool> entry in gameInfo)
            {
                sw.WriteLine(entry.Value);
            }
            sw.Close();
        }

        public static void loadGame()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\HorseSim.txt");
            string[] gameState = System.IO.File.ReadAllLines(@"C:\\HorseSim.txt");

            HorseStats.ateGrass = Boolean.TryParse(gameState[1], out HorseStats.ateGrass);
            HorseStats.hasGuitar = Boolean.TryParse(gameState[2], out HorseStats.hasGuitar);
            HorseStats.shreddedGuitar = Boolean.TryParse(gameState[3], out HorseStats.shreddedGuitar);
            HorseStats.canEnterLimo = Boolean.TryParse(gameState[4], out HorseStats.canEnterLimo);

            if (gameState[0] == "1")
            {
                startingArea.grassyKnoll();
            }
            else if (gameState[0] == "2")
            {
                concertArea.backstage();
            }
            else if (gameState[0] == "3")
            {
                tourBus.inside();
            }
            file.Close();
        }
    }
}
