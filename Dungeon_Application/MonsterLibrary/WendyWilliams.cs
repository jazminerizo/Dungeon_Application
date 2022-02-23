using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DungeonLibrary;

namespace MonsterLibrary
{
    public class WendyWilliams : Monster
    {
        //WendyWilliams is a child/subclass/subtype of Monster

        //FIELDS

        //PROPERTIES

        public bool IsGossiping { get; set; }
        //public bool IsFinallyShuttingUp { get; set; }


        //CONSTRUCTORS
        public WendyWilliams(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isGossiping /*bool isFinallyShuttingUp*/)
            : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)
        {
            IsGossiping = isGossiping;
            //IsFinallyShuttingUp = isFinallyShuttingUp;
        }

        public WendyWilliams()
        {
            //SET MAX values FIRST
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Wendy Williams";
            Life = 6;
            HitChance = 25;
            Block = 20;
            MinDamage = 1;
            Description = "She means no harm! She just makes a living talking trash about every human being ever...";
            IsGossiping = false;
            //IsFinallyShuttingUp = false;
        }

        //METHODS
        public override string ToString()
        {
            return base.ToString() + (IsGossiping ? "She's gossiping aggain..." : "Finally! She shuts up!...");
        }

        public override int CalcBlock()
        {
            //return base.CalcBlock();

            int calculatedBlock = Block;

            if (IsGossiping)
            {
                //If Wendy Williams is gossiping, she gains
                //50% damage reduction

                calculatedBlock += calculatedBlock / 2;
            }
            else
            {
                calculatedBlock -= calculatedBlock / 2;
            }

            return calculatedBlock;

            
        }
    }
}
