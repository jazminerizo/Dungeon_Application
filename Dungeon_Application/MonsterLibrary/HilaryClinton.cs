using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class HilaryClinton : Monster
    {
        //FIELDS
        //private bool _isSurprisinglyFunny;
        //PROPERTIES

        public bool IsWarPlanning { get; set;  }

        //CONSTRUCTORS
        public HilaryClinton(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isWarPlanning)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsWarPlanning = isWarPlanning;
        }

        public HilaryClinton()
        {
            //Set max values first
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Hilary Clinton";
            Life = 6;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "Check to see if she's planning a war!";
            IsWarPlanning = false;
        }

        public override string ToString()
        {
            return base.ToString() + (IsWarPlanning ? "She's planning a war, stop her!" : "No filthy war planning this time. Now ");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsWarPlanning)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }

    }
}
