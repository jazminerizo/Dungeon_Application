using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace Dungeon_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "POKEMON vs. CELEBRITIES WE HATE";
            Console.WriteLine("Your journey begins...\n");

            int score = 0;

            //TODO Create a Player object
            //Need to learn about custom classes first

            Weapon wigSnatcher = new Weapon(1, 8, "Wig Snatcher", 10);

            Player player = new Player("Pikachu", 80, 6, 50, 50, Race.ElectricPokemon, wigSnatcher);


            bool exit = false;

            do
            {
                Console.WriteLine(GetRoom());

                //TODO Create a Monster object in the room
                //Need to learn about custom classes, use them
                //to create numerous monsters, then select one
                //at random

                Console.WriteLine("Choose your player");




                bool reload = false;

                

                    do
                {

                    #region MENU

                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    //Executes upon input without having to hit Enter

                    //Clear the console
                    Console.Clear();

                    //Build out the switch for userChoice
                    switch (userChoice)
                    {
                        //Attack
                        case ConsoleKey.A:
                            //TODO Need to handle combat

                            //TODO Need to handle if the player wins/loses

                            break;

                        //Run Away

                        case ConsoleKey.R:

                            Console.WriteLine("Run away!");

                            //TODO Monster gets an attack of opportunity

                            break;

                        //Player Info

                        case ConsoleKey.P:

                            //TODO Need to display Player's Info/stats

                            break;

                        //Monster Info

                        case ConsoleKey.M:

                            //TODO Need to display Monster's Info/stats

                            break;

                        //Exit

                        case ConsoleKey.X:
                        case ConsoleKey.E:

                            Console.WriteLine("No one likes a quitter...");

                            exit = true;

                            break;


                        default:

                            Console.WriteLine("So that's what we do now? Press any ol' button? Whose mans is this??");

                            break;
                    }


                    #endregion

                    if (player.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("YOU ARE DEAD");
                        Console.ResetColor();
                        exit = true;
                    }


                } while (!reload && !exit);



            } while (!exit); //While exit is NOT TRUE, keep looping


            //Output the player's final score
            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s."));

        }//End Main


        //Create GetRoom() & plug it in to the TODO above
        private static string GetRoom()
        {
            string[] rooms =
            {
                "The room is dark and musty with the smell of Amy Schumer's career... yuck!",
                "You enter a room where Miley Cirus is twerking and gyrating on a ginormous teddy bear.",
                "You arrive in a rainbow room filled with multi colored balloons, confetti on the ground, glitter on the walls, and Tekashi 6ix9ine playfully jumping on the bed. Enjoy!",
                
            };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }


    }//End class


}//End Namespace