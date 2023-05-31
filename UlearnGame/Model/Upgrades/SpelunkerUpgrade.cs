using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class SpelunkerUpgrade : Upgrade
    {
        public SpelunkerUpgrade(Game game, Upgrade[] previous = null) : base(game)
        {
            IsObtained = false;
            Previous = previous;
            ImagePath1 = Texture.SpelunkerIcon;
            ImagePath2 = Texture.SpelunkerIcon2;
            Title = "СПЕЛЕОЛОГ";
            Description = "Пора исследовать глубины пещер!\n" +
                "На поле появляются кристаллы и летучие мыши.\n" +
                "+10% шанс появления доп. объекта на поле.";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.Field.ChangeDoubleGenerationChance(0.1);
                Game.Field.SpelunkerUpgrade();
                IsObtained = true;
            }
        }
    }
}
