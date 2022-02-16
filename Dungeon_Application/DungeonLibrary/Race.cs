using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //We cannot add/create an ENUM directly using Visual Studio's graphical interface.
    //So, if we want an enum, we can simply change the word "class" to "enum".

    //REMEMBER: Only the FIRST class in a Class Library will be public by default.
    //If you want to use this class (or enum, in this case) elsewhere, you will need 
    //to add the public keyword.

    public enum Race
    {
        //Single values, NO spaces in the value, comma separated
        ElectricPokemon,
        FirePokemon,
        GrassPokemon,
        WaterPokemon,
        FairyPokemon,
        NormalPokemon,
        GroundPokemon,
        PsychicPokemon,
        Human
        
        
    }
}

