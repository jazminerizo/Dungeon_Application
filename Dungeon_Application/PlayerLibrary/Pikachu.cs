using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace PlayerLibrary
{
    public class Pikachu : Player
    {
        //FIELDS
        private bool _isGeneratingElectricity;

        //PROPERTIES
        public bool IsGeneratingElectricity { get; set; }
    }
}
