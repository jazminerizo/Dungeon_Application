using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;
using MonsterLibrary;


namespace Dungeon_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "POKEMON vs. CELEBRITIES WE HATE";
            Console.WriteLine("Your journey begins...\n");

            int score = 0;


            
            Weapon wigSnatcher = new Weapon(1, 8, "Wig Snatcher", 11
                );

            Player player = new Player("Pikachu", 10, 11, 7, 7, Race.ElectricPokemon, wigSnatcher);


            //Console.Clear();\
            bool exit = false;

            do
            {
                Console.WriteLine(GetRoom());

                WendyWilliams wW = new WendyWilliams();

                HilaryClinton hC = new HilaryClinton();

                TaylorSwift tS = new TaylorSwift();

                Monster[] monsters = { wW, hC, tS };

                Random rand = new Random();

                int randomMonster = rand.Next(monsters.Length);

                Monster monster = monsters[randomMonster];

                Console.WriteLine("\nIn this room you see the monster " + monster.Name);



                //bool exit1 = false;
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

                    ConsoleKey userChoice3 = Console.ReadKey(true).Key;
                    

                    
                    Console.Clear();

                    
                    switch (userChoice3)
                    {
                        
                        case ConsoleKey.A:

                            Combat.DoBattle(player, monster);

                            if (monster.Life <= 0)
                            {
                               

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYou killed {0}!\n", monster.Name);
                                Console.ResetColor();
                                reload = true;
                                
                                score++;
                            }


                            break;

                        //Run Away

                        case ConsoleKey.R:

                            Console.WriteLine("Run away!");

                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player); //Attack of opportunity
                            Console.WriteLine();
                            reload = true;

                            break;

                        //Player Info

                        case ConsoleKey.P:

                            Console.WriteLine("Player Info");

                            Console.WriteLine(player);
                            Console.WriteLine("Monsters defeated: " + score);

                            break;

                        //Monster Info

                        case ConsoleKey.M:

                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);

                            break;

                        //Exit

                        case ConsoleKey.X:
                        case ConsoleKey.E:

                            Console.WriteLine("QUITTER...");

                            exit = true;

                            break;


                        default:

                            Console.WriteLine("Invalid input. Try again, sweetie.");

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

            } while (!exit);

            



            
            Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s."));

        }//End Main


        
        private static string GetRoom()
        {
            string[] rooms =
            {
                "The room is dark and musty with the foul smell of Amy Schumer's career... yuck!",
                "You enter a room where Miley Cirus is gyrating by a ginormous teddy bear.",
                "You arrive in a rainbow room filled with multi colored balloons, confetti on the ground, glitter on the walls, and Tekashi 6ix9ine playfully jumping on the bed. Enjoy!",

            };

            Random rand = new Random();

            int indexNbr = rand.Next(rooms.Length);

            string room = rooms[indexNbr];

            return room;

        }


    }//End class


}//End Namespace






//Console.WriteLine("\nChoose your weapon\n" +
//    "1) Famous Weapon\n" +
//    "2) Wig Snatcher\n");

//string userChoice1 = Console.ReadLine().ToUpper();

//Console.Clear();

//switch (userChoice1)
//{
//    case "1":
//        Console.WriteLine("Famous Weapon");

//        break;
//    case "2":
//        Console.WriteLine("Wig Snatcher");
//        Console.ReadLine();
//        break;
//    default:
//        Console.WriteLine("Invalid input. Please try again. ");
//        break;
//}