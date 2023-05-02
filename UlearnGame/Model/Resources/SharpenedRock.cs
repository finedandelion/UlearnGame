using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class SharpenedRock : Resource
    {
        public SharpenedRock()
        {
            Name = "ЗАОСТР. КАМЕНЬ";
            Description = "Острый как бритва. Незаменимая вещь в ремесле.";
            ImagePath = ProgramInitials.GetImage("SharpenedRock.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedSharpenedRock.png");
        }
    }
}
