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
        protected Random resourcesRandom = new Random();
        protected Game Game { get; set; }
        public double StartCapacity { get; protected set; }
        public double Capacity { get; protected set; }
        public Image? Image { get; protected set; }
        public Image? Image2 { get; protected set; }
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
