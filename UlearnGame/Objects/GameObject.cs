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
        protected Random resourcesRandom = new Random();

        protected int ResourceRandomCap { get; set; }
        public double Capacity { get; protected set; }
        public Image ImagePath { get; set; }
        public Resource ResourcesDrop { get; set; }

        public virtual Resource GenerateResource()
        {
            throw new NotImplementedException();
        }

        public virtual void ChangeState(int clickPower)
        {
            throw new NotImplementedException();
        }
    }
}
