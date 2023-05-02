using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Objects
{
    public class Gold : GameObject
    {
        private static int GoldCapicty = 15;
        private static double GoldExperience = 9;

        private Resource[] resourcesDrop => GenerateResources();
        public Gold(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 2;
            ResourceRandomCapSecond = 3;
            StartCapacity = GoldCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = ProgramInitials.GetImage("Gold.png");
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Rock() { Amount = Game.ResourceLowCap + 2 },
                new GoldenIngot() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 1, ResourceRandomCapFirst + 1) }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override double GainExperience()
        {
            return GoldExperience;
        }
    }
}
