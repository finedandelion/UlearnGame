using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class Fiber : Resource
    {
        public Fiber()
        {
            Name = "ВОЛОКНО";
            Description = "Тонкие органические волокна. Пригодны для вязаяния.";
            ImagePath = ProgramInitials.GetImage("Fiber.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedFiber.png");
        }
    }
}
