using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class Rock : Resource
    {
        public Rock()
        {
            Name = "КАМЕНЬ";
            Description = "Раздробленные части небольшого камня.";
            ImagePath = ProgramInitials.GetImage("Rock.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedRock.png");
        }
    }
}
