using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class DullTotem : Resource
    {
        public DullTotem()
        {
            Name = "ПУСТОЙ ТОТЕМ";
            Description = "Оболочка тотема. Не излучает жизненных сил.";
            ImagePath = ProgramInitials.GetImage("DullTotem.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedDullTotem.png");
        }
    }
}
