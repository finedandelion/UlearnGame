using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UlearnGame.Model.Resources
{
    public class Bowl : Resource
    {
        public Bowl()
        {
            Name = "МИСКА";
            Description = "В неё можно ложить еду для подношений.";
            ImagePath = ProgramInitials.GetImage("Bowl.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedBowl.png");
        }
    }
}
