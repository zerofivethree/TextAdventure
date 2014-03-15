using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class concertArea
    {
        /// <summary>
        /// The second stage of the game! Backstage at the rock concert.
        /// </summary>
        static public void backstage()
        {
            Console.Clear();
            Console.WriteLine("Backstage");
            Console.WriteLine();
            Console.WriteLine("You find yourself backstage at ROCK N ROLL CONCERT.");
            Console.WriteLine("There's lots of bustling people, supermodels, beer, and musical instruments.");
            Console.WriteLine("The ROCKSTAR tells you to get ready to go on stage in 5 minutes.");

            while (true)
            {
                Console.WriteLine();
                Console.Write(">");
                string action = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (action == "look")
                {
                    Console.WriteLine("You are backstage at a rock n roll concert.");
                    Console.WriteLine("There's lots of bustling people, supermodels, beer, and musical instruments.");
                    Console.WriteLine("You see a bottle of GLUE, a bottle of BEER, and the entrance to the STAGE.");
                }
                else if (action == "introspect")
                {
                    Console.WriteLine("You're gonna make it big! Horse David Byrne would be proud!");
                    Console.WriteLine("The rest of your troubles don't seem to matter as much right now, and you like how that feels.");
                    Console.WriteLine("You wish that you could forget about all your life troubles forever. You wish mom and dad");
                    Console.WriteLine("could get back together and be happy again. You wish people would like you for who you are.");
                    Console.WriteLine("You wish you could meet Horse David Byrne, just once. At least he understands you.");
                }
                else if (action == "look glue" || action == "get glue")
                {
                    Console.WriteLine("...grandpa?");
                }
                else if (action == "get beer" || action == "use beer" || action == "drink beer")
                {
                    if (HorseStats.hasBeer == false)
                    {
                        Console.WriteLine("Nice try, dodongo! You're only thirteen horse years old.");
                        HorseStats.hasBeer = true;
                    }
                    else
                    {
                        Console.WriteLine("Despite your horse age, you scoop up the beer when no one's looking.");
                        Console.WriteLine("You'll keep this in your pocket for later.");
                    }
                }
                else if (action == "go stage")
                {
                    Console.WriteLine("You head out to the stage.");
                    concertArea.onStage();
                }
                else if (action == "call" || action == "argue")
                {
                    Console.WriteLine("You can't do that here you nincompoop!");
                }
                else if (action == "help")
                {
                    Console.WriteLine("Basic commands: look, use, go, eat, call, argue, introspect.");
                }
                else
                {
                    Console.WriteLine("I didn't understand your command! Type \'help\' to view a list of the basic commands.");
                }
            }
            
        }

        static public void onStage()
        {

        }
    
    }
}
