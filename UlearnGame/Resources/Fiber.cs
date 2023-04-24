using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Resources
{
    internal class Fiber : Resource
    {
        public Fiber() 
        {
            Name = "ВОЛОКНО";
            Description = "Тонкие органические волокна. Пригодны для вязаяния.";
            ImagePath = GameForm.GetImage("Fiber.png");
            ImagePath2 = GameForm.GetImage("SelectedFiber.png");
        }
    }
}
