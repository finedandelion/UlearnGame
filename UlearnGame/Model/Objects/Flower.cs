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

        private Dictionary<int, Image> flowerTextures2 = new Dictionary<int, Image>()
        {
            { 0, Texture.Flower12 },
            { 1, Texture.Flower22 },
            { 2, Texture.Flower32 },
            { 3, Texture.Flower42 },
            { 4, Texture.Flower52 },
        };
        private static int FlowerCapicty = 4;
        private static double FlowerExperience = 4;
        private Resource[] resourcesDrop => GenerateResources();
        public Flower(Game game)
        {
            Game = game;
            StartCapacity = FlowerCapicty * Game.CapacityHardnessMultiplier;
            Capacity = StartCapacity;
            Image = ChooseTexture(new Random().Next(0, 5));
            Image2 = ChooseTexture2(new Random().Next(0, 5));
            ResourcesDrop = resourcesDrop;
        }

        public override Resource[] GenerateResources()
        {
            return new Resource[]
            {
                new Fiber() { Amount = resourcesRandom.Next(0, 3) + Game.ResourceBonus},
                new Petals() { Amount = resourcesRandom.Next(4, 13) + Game.ResourceBonus }
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

        private Image ChooseTexture2(int textureVariant)
        {
            return flowerTextures2[textureVariant];
        }
    }
}
