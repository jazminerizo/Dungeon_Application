using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class TaylorSwift : Monster
    {

        public DateTime HourChangeBack { get; set; }
        public bool IsToneDeaf { get; set; }

        public TaylorSwift(string name, int life, int maxLife, int hitChance, int block, int minDamage, int maxDamage, string description, bool isToneDeaf)
                : base(name, life, maxLife, hitChance, block, minDamage, maxDamage, description)

        {
            IsToneDeaf = isToneDeaf;
        }

        public TaylorSwift()
        {
            Name = "Taylor Swift";
            MaxLife = 5;
            MaxDamage = 2;
            Life = 5;
            HitChance = 15;
            Block = 20;
            MinDamage = 1;
            Description = "Avoid the tone deaf-ness!!";
            HourChangeBack = DateTime.Now;


            if (HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18)
            {
                HitChance += 10;
                Block += 10;
                MinDamage += 1;
                MaxDamage += 2;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}",
                base.ToString(),
                HourChangeBack.Hour < 6 || HourChangeBack.Hour > 18 ? "It looks strong and angry." : "It looks weak and pathetic in the daylight.");
        }
    }
}

