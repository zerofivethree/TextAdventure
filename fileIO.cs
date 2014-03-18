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
        public static void saveGame(int area, Dictionary<int, bool> gameInfo)
        {
            // Saves an int for the area the player was in, followed by a list of boolean values, and then the inventory in strings
            // bool values are the flags of what the player has done in HorseStats
            Dictionary<int, bool> gameDictSave = new Dictionary<int, bool>();
            StreamWriter sw = new StreamWriter(@"C:\\HorseSim.txt", false);
            sw.WriteLine(area);
            foreach(KeyValuePair<int, bool> entry in gameInfo)
            {
                sw.WriteLine(entry.Value);
            }
            for (int x = 0; x < Inventory.inventory.Count; x++)
            {
                sw.WriteLine(Inventory.inventory[x]);
            }
            sw.Close();
        }

        public static void loadGame()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("C:\\HorseSim.txt");
            string[] gameState = System.IO.File.ReadAllLines(@"C:\\HorseSim.txt");

            // Sets HorseStats flags based on lines in txt file
            HorseStats.ateGrass = Boolean.TryParse(gameState[1], out HorseStats.ateGrass);
            HorseStats.shreddedGuitar = Boolean.TryParse(gameState[2], out HorseStats.shreddedGuitar);
            HorseStats.canEnterLimo = Boolean.TryParse(gameState[3], out HorseStats.canEnterLimo);
            HorseStats.hasBeer = Boolean.TryParse(gameState[4], out HorseStats.hasBeer);
            HorseStats.canShredSolo = Boolean.TryParse(gameState[5], out HorseStats.canShredSolo);
            HorseStats.canSurf = Boolean.TryParse(gameState[6], out HorseStats.canSurf);
            HorseStats.isSurfing = Boolean.TryParse(gameState[7], out HorseStats.isSurfing);
            HorseStats.hasAcid = Boolean.TryParse(gameState[8], out HorseStats.hasAcid);
            HorseStats.drankBeer = Boolean.TryParse(gameState[9], out HorseStats.drankBeer);
            HorseStats.hasPaper = Boolean.TryParse(gameState[10], out HorseStats.hasPaper);
            
            // Clears inventory, then adds back items starting from line 5 in txt file
            Inventory.inventory.Clear();
            for (int x = 11; x < gameState.Length; x++)
            {
                Inventory.addItems(gameState[x]);
            }

            // Loads corresponding area based on first number in txt file
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
                concertArea.onStage();
            }
            else if (gameState[0] == "4")
            {
                concertArea.backOnStage();
            }
            else if (gameState[0] == "5")
            {
                tourBus.inside();
            }
            else 
            file.Close();
        }
    }
}
