using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class Berries : Resource
    {
        public Berries()
        {
            Name = "ЯГОДЫ";
            Description = "Ягоды, собранные с куста. На вид выглядят сочно!";
            ImagePath = ProgramInitials.GetImage("Berries.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedBerries.png");
        }
    }
}
