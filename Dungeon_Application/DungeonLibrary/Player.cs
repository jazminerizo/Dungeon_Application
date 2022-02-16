using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //FIELDS
        //Attributes: Name, HitChance, Block, Life, MaxLife, Race, Weapon
        //Only need to create fields for any attributes that require business rules
        //private int _life;

        //PROPERTIES
        //Automatic Properties: A shortcut syntax that allows you to create a shortened
        //version of a public property. Automatic Properties have an open getter and 
        //setter. They automatically create default fields for you at runtime.

        //public string Name { get; set; }

        //public int HitChance { get; set; }

        //public int Block { get; set; }

        //public int MaxLife { get; set; }

        public Race CharacterRace { get; set; }

        public Weapon EquippedWeapon { get; set; }

        //You CANNOT have business rules with automatic properties.
        //If you need business rules, you MUST have the field declared
        //above and write the property the "long way"
        //public int Life
        //{
        //    get { return _life; }
        //    set
        //    {
        //        //Business rule: Life should NOT exceed MaxLife
        //        if (value <= MaxLife)
        //        {
        //            //Good to go!
        //            _life = value;
        //        }
        //        else
        //        {
        //            //Tried to set a value for life that was greater than MaxLife.
        //            //So, let's default the life value to the MaxLife value
        //            _life = MaxLife;
        //        }
        //    }
        //}

        //CONSTRUCTORS
        //ONLY MAKE A FULLY-QUALIFIED CONSTRUCTOR
        //We don't want to allow anyone to make a blank Player, so they MUST
        //give us all of the info necessary
        public Player(string name, int hitChance, int block, int life, int maxLife,
            Race characterRace, Weapon equippedWeapon)
        {
            //Since Life depends on MaxLife, SET MAXLIFE FIRST
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

            return string.Format("-=-= {0} =-=-\n" +
                "Life: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon:\n{4}\nBlock: {5}\nDescription: {6}",
                Name,
                Life,
                MaxLife,
                //HitChance,
                CalcHitChance(),
                EquippedWeapon,
                Block,
                description);

        }//End ToString()

        public override int CalcDamage()
        {
            //return base.CalcDamage();

            //Weapon will be the basis for how our player deals damage
            //Weapon has MinDamage and MaxDamage properties. Let's
            //use a Random object to randomly select how much damage
            //our Weapon can do with any given attack.

            Random rand = new Random();

            //Determine the range of potential damage
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