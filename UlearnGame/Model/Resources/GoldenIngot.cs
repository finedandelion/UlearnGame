using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UlearnGame.Model.Resources
{
    public class GoldenIngot : Resource
    {
        public GoldenIngot()
        {
            Name = "ЗОЛОТАЯ РУДА";
            Description = "Блестит! Самый настоящий и неподдельный самородок.";
            ImagePath = ProgramInitials.GetImage("GoldenIngot.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedGoldenIngot.png");
        }
    }
}
