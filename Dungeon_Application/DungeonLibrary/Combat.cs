using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        

        public static void DoAttack(Character attacker, Character defender)
        {
            
            Random rand = new Random();
            int coinFlip = rand.Next(1, 3);
            System.Threading.Thread.Sleep(30);

            if (coinFlip <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                
                int damageDealt = attacker.CalcDamage();

                
                defender.Life -= damageDealt;

               
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} damage!",
                    attacker.Name, defender.Name, damageDealt);
                Console.ResetColor();
            }
            else
            {
                
                Console.WriteLine("{0} missed!", attacker.Name);
            }
        }//End DoAttack();

        public static void DoBattle(Player player, Monster monster)
        {
            
            DoAttack(player, monster);

            
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }//End DoBattle();

        public static void DoBattle(object player, Monster monster)
        {
            throw new NotImplementedException();
        }

        //private static void DoAttack(Monster monster, Player player)
        //{
        //    throw new NotImplementedException();
        //}

        //private static void DoAttack(Player player, Monster monster)
        //{
        //    throw new NotImplementedException();
        //}
    }
}