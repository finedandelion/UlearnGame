using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Resources;

namespace UlearnGame.Objects
{
    internal class GameObject : IObject
    {
        protected static double CapacityHardnessMultiplier = 1;
        public double ObjectCapacity { get; set; }
        public Image ObjectImage { get; set; }
        public Resource ObjectResourceDrop { get; set; }
    }
}
