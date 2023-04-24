using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Resources
{
    internal class Rock : Resource
    {
        public Rock()
        {
            Name = "КАМЕНЬ";
            Description = "Раздробленные части небольшого камня.";
            ImagePath = GameForm.GetImage("Rock.png");
            ImagePath2 = GameForm.GetImage("SelectedRock.png");
        }
    }
}
