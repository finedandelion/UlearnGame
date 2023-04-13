using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Resources;

namespace UlearnGame.Objects
{
    internal class Tree : GameObject
    {
        public Tree()
        {
            ObjectCapacity = 10 * CapacityHardnessMultiplier;
            ObjectImage = Image.FromFile("Tree.png");
            ObjectResourceDrop = new Wood(); 
        }
    }
}
