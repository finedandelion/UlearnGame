using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UlearnGame.Model.Resources
{
    public class Petals : Resource
    {
        public Petals()
        {
            Name = "ЛЕПЕСТКИ";
            Description = "Из них получился бы красивый венок.";
            ImagePath = ProgramInitials.GetImage("Petals.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedPetals.png");
        }
    }
}
