using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Inventory
    {
        /*
         * Most of this code is pretty much straight from the open-source adventure.
         * It's pretty basic, so there wasn't really a reason to do it another way.
         * Also, inventory is barely even used in my game. This is just here so you can remember what you have.
         */ 

        public static List<string> inventory = new List<string>();

        public static void addItems(string name)
        {
            inventory.Add(name);
        }

        public static void viewInventory()
        {
            for (int x = 0; x < inventory.Count; x++)
            {
                Console.WriteLine(inventory[x]);
            }
        }
    }
}
