using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Resources
{
    public class Leaf : Resource
    {
        public Leaf()
        {
            Name = "ЛИСТОК";
            Description = "Животные едят листья. Почему бы не попробовать?";
            ImagePath = ProgramInitials.GetImage("Leaf.png");
            ImagePath2 = ProgramInitials.GetImage("SelectedLeaf.png");
        }
    }
}
