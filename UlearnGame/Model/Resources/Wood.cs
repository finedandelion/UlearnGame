using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class Wood : Resource
    {
        public Wood()
        {
            Name = "ДРЕВЕСИНА";
            Description = "Довольно крепкая древесина твёрдых пород.";
            ImagePath = ProgramInitials.GetImage("Wood.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedWood.png");
        }
    }
}
