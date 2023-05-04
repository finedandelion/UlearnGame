using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class GathererUpgrade : Upgrade
    {
        public GathererUpgrade(Game game, Upgrade[] previous = null)
        {
            IsObtained = false;
            Game = game;
            Previous = previous;
            ImagePath1 = Texture.GathererIcon;
            ImagePath2 = Texture.GathererIcon2;
            Title = "СОБИРАТЕЛЬ";
            Description = "Вы восстанавливаете связь с природой. На поле появляются кусты и цветы. Даёт возможность" +
                " создавать мешок, повышающий кол-во собранных ресурсов.";
    }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.Field.GathererUpgrade();
                IsObtained = true;
            }
        }
    }
}
