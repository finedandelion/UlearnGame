using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class HunterUpgrade : Upgrade
    {
        public HunterUpgrade(Game game, Upgrade[] previous = null)
        {
            IsObtained = false;
            Game = game;
            Previous = previous;
            ImagePath1 = Texture.HunterIcon;
            ImagePath2 = Texture.HunterIcon2;
            Title = "ОХОТНИК";
            Description = "Живые существа заполняют ваши просторы.\n" +
                "На поле появляются слизни и олени.\n";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.Field.HunterUpgrade();
                IsObtained = true;
            }
        }
    }
}
