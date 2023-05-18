using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class FormerUpgrade : Upgrade
    {
        public FormerUpgrade(Game game, Upgrade[] previous = null)
        {
            IsObtained = false;
            Game = game;
            Previous = previous;
            ImagePath1 = Texture.GathererIcon;
            ImagePath2 = Texture.GathererIcon2;
            Title = "СОЗИДАТЕЛЬ";
            Description = "Вы познали способы владения природой.\n" +
                "Кол-во появляемых придметов увеличено вдвое.\n";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.Field.FormerUpgrade();
                IsObtained = true;
            }
        }
    }
}
