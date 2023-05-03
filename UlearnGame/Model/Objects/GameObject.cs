using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Objects
{
    public class GameObject : IObject
    {
        protected static double CapacityHardnessMultiplier = 1;
        protected static double ExperienceMultiplier = 1;

        protected Random resourcesRandom = new Random();
        protected Game Game { get; set; }
        protected int ResourceRandomCapFirst { get; set; }
        protected int ResourceRandomCapSecond { get; set; }
        public double StartCapacity { get; protected set; }
        public double Capacity { get; protected set; }
        public Image? ImagePath { get; protected set; }
        public SoundPlayer? ClickSound { get; protected set; }
        public Resource[]? ResourcesDrop { get; set; }

        public virtual Resource[] GenerateResources()
        {
            throw new NotImplementedException();
        }

        public virtual void ChangeState()
        {
            throw new NotImplementedException();
        }

        public virtual void GainExperience()
        {
            throw new NotImplementedException();
        }
    }
}
