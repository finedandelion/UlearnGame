using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Gift : GameObject
    {
        private static int GiftCapicty = 8;
        private static double GiftExperience = 7;
        private Resource[] resourcesDrop => GenerateResources();
        public Gift(Game game)
        {
            Game = game;
            StartCapacity = GiftCapicty;
            Capacity = StartCapacity;
            Image = Texture.Gift;
            Image2 = Texture.Gift2;
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            var resources = Game.AscendingSystem.CurrentResources;
            var type = resources[new Random().Next(0, resources.Length)].GetType();
            var resource = Activator.CreateInstance(type) as Resource;
            resource.Amount = 1;
            return new Resource[] { resource };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(GiftExperience * Game.ExperienceMultiplier);
        }
    }
}
