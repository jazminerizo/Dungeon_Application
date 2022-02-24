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
                
                if (value > 0 && value <= MaxDamage)
                {
                    
                    _minDamage = value;
                }
                else
                {
                    
                    _minDamage = 1;
                }
            }
        }

        
        //(FQCTOR)

        public Weapon(int minDamage, int maxDamage, string name, int bonusHitChance)
        {
            


           
            MaxDamage = maxDamage;
           
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            
        }

        


        
        public override string ToString()
        {
            //return base.ToString();

            return string.Format("{0}\t{1} to {2} Damage\n" +
                "Bonus Hit: {3}%\t",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitChance);
        }
    }
}