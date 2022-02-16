using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //FIELDS
        //Attributes: MinDamage, MaxDamage, Name, BonusHitChance, 2-Handed?
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        

        //PROPERTIES
        //Properties with business rules last

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

      

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
        //Create a fully qualified constructor (FQCTOR)

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance)
        {
            //Here, the PROPERTIES are being assigned the value of the PARAMETERS
            //When we use the constructor to create a Weapon object, we MUST provide
            //the values listed in the parentheses.


            //If you have ANY properties that have business rules
            //that are based off of any OTHER properties...
            //Set the other properties FIRST
            MaxDamage = maxDamage;
            //Since MinDamage has business rules that depend on
            //the value of MaxDamage, we MUST set MaxDamage before
            //MinDamage.
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            
        }

        //NO DEFAULT CONSTRUCTOR! We do not want anyone to make
        //a blank weapon that is missing any of the info related 
        //to that weapon.


        //METHODS
        //Since DungeonLibrary.Weapon is probably NOT what we want
        //printed to the screen, we will need to override the ToString()
        public override string ToString()
        {
            //return base.ToString();

            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\t{4}",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance);
        }
    }
}