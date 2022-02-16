using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        //FIELDS
        private int _minDamage;

        //PROPERTIES

        public int MaxDamage { get; set; }

        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //Shouldn't be more than the MaxDamage
                //shouldn't be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    //This follows the guidelines above, so go ahead and assign
                    //the field the value that was provided
                    _minDamage = value;
                }
                else
                {
                    //Tried to set the value outside of the ranges we deemed appropriate
                    //Therefor, default the value to 1
                    _minDamage = 1;
                }
            }
        }

        //CONSTRUCTORS

        public Monster(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description)
        //: base(name, maxLife, life, hitChance, block)
        {
            //Because Monster inherits from an abstract class (Character), it has no
            //constructors to inherit from. (Technically, we never inherit constructors,
            //but we are able to use the : base(params) shortcut for automatic assignment
            //of any inherited properties). Since Character has no constructor, it also
            //does nothing for assignment of its properties. When inheriting from an abstract
            //class, we enjoy all of the benefits related to fields, properties, and methods, 
            //but we still need to manually perform assignment for all properties in the ctor.

            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block;
            MinDamage = minDamage;
            Description = description;
        }

        public Monster() { }

        //METHODS
        public override string ToString()
        {
            //return base.ToString();

            return string.Format("\n********** MONSTER ***********\n" +
                "{0}\nLife: {1} of {2}\nDamage: {3} to {4}\n" +
                "Block: {5}\nDescription:\n{6}\n",
                Name,
                Life,
                MaxLife,
                MinDamage,
                MaxDamage,
                Block,
                Description);
        }

        public override int CalcDamage()
        {
            //return base.CalcDamage();

            Random rand = new Random();

            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}