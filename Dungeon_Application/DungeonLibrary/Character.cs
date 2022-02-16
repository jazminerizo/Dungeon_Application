using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //The ABSTRACT keyword indicates that the thing being modified (class here)
        //has an incomplete implementation. The abstract modifier can be used with 
        //classes, methods, and properties. We can use the abstract modifier in a
        //class declaration (as shown above) to indicate that the class is intended
        //to only be a base(parent) class of other classes.

        //We brought over all of the fields/properties from a Player that 
        //would be appropriate/applicable for any Character.

        //FIELDS
        private int _life;

        //PROPERTIES
        public string Name { get; set; }

        public int HitChance { get; set; }

        public int Block { get; set; }

        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                //Business rule: Life should NOT exceed MaxLife
                if (value <= MaxLife)
                {
                    //Good to go!
                    _life = value;
                }
                else
                {
                    //Tried to set a value for life that was greater than MaxLife.
                    //So, let's default the life value to the MaxLife value
                    _life = MaxLife;
                }
            }
        }

        //CONSTRUCTORS
        //We have already done all of the work for the FQCTOR of Player, so we'll opt
        //not to create any constructors here. We do still get access to the default one,
        //but we will be unable to use it since this class is abstract -- it is never
        //meant to be constructed as just a Character.

        //METHODS
        //No need to override the ToString(). We will NEVER create a Character object,
        //it will always be a Player or a Monster.

        //Below are methods we want to be inherited by Player and Monster, so we are 
        //creating default versions of each method here. The child classes will use
        //these methods if they do not override them for their own, unique versions.

        public virtual int CalcBlock()
        {
            //To be able to override this in a child class, we
            //MUST make it VIRTUAL

            //This basic version just returns block, but this will
            //give us the option to do something different in any 
            //child classes.

            return Block;
        }

        //MINI LAB! Make the CalcHitChance method and have it return HitChance.
        //Make it available in other namespaces and be sure it is overrideable.
        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
            //Starting with return 0. We will override
            //this method for Monster and Player so they
            //have their own unique ways to calculate
            //the damage they deal.
        }

    }
}