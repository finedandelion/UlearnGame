using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UlearnGame.Model.Resources
{
    public class Salad : Resource
    {
        public Salad() 
        {
            Name = "МАЛ. ПОДНОШЕНИЕ";
            Description = "Толчёные ягоды и листья. Надейся на милость.";
            ImagePath = ProgramInitials.GetImage("Salad.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedSalad.png");
        }

    }
}
