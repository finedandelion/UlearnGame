using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Objects
{
    public class Slime : GameObject
    {
        private static int SlimeCapicty = 20;
        private static double SlimeExperience = 12;

        private Resource[] resourcesDrop => GenerateResources();
        public Slime(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 4;
            StartCapacity = SlimeCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = ProgramInitials.GetImage("Slime.png");
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[1]
            {
                new SlimeDrop() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 2, ResourceRandomCapFirst + 1) }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override double GainExperience()
        {
            return SlimeExperience;
        }
    }
}
