using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class AmySchumer : Monster
    {
        //FIELDS
        private bool _isSurprisinglyFunny;
        //PROPERTIES

        public bool IsSurprisinglyFunny { get; set;  }

        //CONSTRUCTORS
        public AmySchumer(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isSurprisinglyFunny)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsSurprisinglyFunny = isSurprisinglyFunny;
        }

        public AmySchumer()
        {
            //Set max values first
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Amy Schumer";
            Life = 6;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "There she goes, making lame jokes again...";
            IsSurprisinglyFunny = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsSurprisinglyFunny ? "You laughed when she told a joke!" : "There she goes, making lame jokes again...");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsSurprisinglyFunny)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

    }
}
