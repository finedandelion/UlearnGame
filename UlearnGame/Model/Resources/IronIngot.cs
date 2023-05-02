using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class IronIngot : Resource
    {
        public IronIngot()
        {
            Name = "ЖЕЛЕЗНАЯ РУДА";
            Description = "Железо течёт в крови. Именно поэтому оно нравится божеству.";
            ImagePath = ProgramInitials.GetImage("IronIngot.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedIronIngot.png");
        }
    }
}
