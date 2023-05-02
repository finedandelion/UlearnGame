using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Objects
{
    public class Stone : GameObject
    {
        private static int StoneCapicty = 12;
        private static double StoneExperience = 7;
        private Resource[] resourcesDrop => GenerateResources();
        public Stone(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 2;
            StartCapacity = StoneCapicty * CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = ProgramInitials.GetImage("Stone.png");
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[1]
            {
                new Rock() { Amount = resourcesRandom.Next(Game.ResourceLowCap + 1, ResourceRandomCapFirst + 1) }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override double GainExperience()
        {
            return StoneExperience;
        }
    }
}
