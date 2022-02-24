using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        

        public Race CharacterRace { get; set; }

        public Weapon EquippedWeapon { get; set; }

       
        public Player(string name, int hitChance, int block, int life, int maxLife,
            Race characterRace, Weapon equippedWeapon)
        {
           
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
        }


        //METHODS
        public override string ToString()
        {
            //return base.ToString();

            string description = "";

            switch (CharacterRace)
            {
                case Race.ElectricPokemon:
                    description = "Electric Pokemon";
                    break;
                case Race.FirePokemon:
                    description = "Fire Pokemon";
                    break;
                case Race.GrassPokemon:
                    description = "Grass Pokemon";
                    break;
                case Race.WaterPokemon:
                    description = "Water Pokemon";
                    break;
                case Race.FairyPokemon:
                    description = "Fairy Pokemon";
                    break;
                case Race.NormalPokemon:
                    description = "Normal Pokemon";
                    break;
                case Race.GroundPokemon:
                    description = "Ground Pokemon";
                    break;
                case Race.PsychicPokemon:
                    description = "Psychic Pokemon";
                    break;
                case Race.Human:
                    description = "Human";
                    break;
                
            }//End switch

            return string.Format("=*=*=*= {0} =*=*=*=\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon:\n{4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                HitChance,
                CalcHitChance(),
                EquippedWeapon,
                Block,
                description);

        }//End ToString()

        public override int CalcDamage()
        {
            //return base.CalcDamage();

            
            Random rand = new Random();

            
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            //Return damage
            return damage;
        }

        public override int CalcHitChance()
        {
            //return base.CalcHitChance();

            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }


    }//End Class
}//End Namespace