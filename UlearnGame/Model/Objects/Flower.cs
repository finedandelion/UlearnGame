using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;
using UlearnGame.Visual;

namespace UlearnGame.Model.Objects
{
    public class Flower : GameObject
    {
        private Dictionary<int, Image> flowerTextures = new Dictionary<int, Image>()
        {
            { 0, Texture.Flower1 },
            { 1, Texture.Flower2 },
            { 2, Texture.Flower3 },
            { 3, Texture.Flower4 },
            { 4, Texture.Flower5 },
        };
        private static int FlowerCapicty = 4;
        private static double FlowerExperience = 6;
        private static Random textureRandom = new Random();
        private Resource[] resourcesDrop => GenerateResources();
        public Flower(Game game)
        {
            Game = game;
            ResourceRandomCapFirst = 2;
            ResourceRandomCapSecond = 6;
            StartCapacity = FlowerCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            ImagePath = ChooseTexture(textureRandom.Next(0, 5));
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[2]
            {
                new Fiber() { Amount = resourcesRandom.Next(0, ResourceRandomCapFirst + 1) + Game.ResourceBonus},
                new Petals() { Amount = resourcesRandom.Next(2, ResourceRandomCapSecond + 1) + Game.ResourceBonus }
            };
        }

        public override void ChangeState()
        {
            Capacity -= Game.ClickPower;
        }

        public override void GainExperience()
        {
            Game.AddExperience(FlowerExperience *  Game.ExperienceMultiplier);
        }

        private Image ChooseTexture(int textureVariant)
        {
            return flowerTextures[textureVariant];
        }
    }
}
