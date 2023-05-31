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
        public GathererUpgrade(Game game, Upgrade[] previous = null) : base(game)
        {
            IsObtained = false;
            Previous = previous;
            ImagePath1 = Texture.GathererIcon;
            ImagePath2 = Texture.GathererIcon2;
            Title = "СОБИРАТЕЛЬ";
            Description = "Вы восстанавливаете связь с природой.\n" +
                "На поле появляются кусты и цветы.\n" +
                "-1c Таймера.";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.Field.GathererUpgrade();
                Game.ChangeFieldUpdateRate(-1);
                IsObtained = true;
            }
        }
    }
}
