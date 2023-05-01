using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class Plank : Resource
    {
        public Plank()
        {
            Name = "Доска";
            Description = "Приобрётшая новый вид древесина. Гладкая на ощупь.";
            ImagePath = ProgramInitials.GetImage("Plank.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedPlank.png");
        }
    }
}
