using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class CraftsmanUpgrade : Upgrade
    {
        public CraftsmanUpgrade(Game game, Upgrade[] previous = null) : base(game)
        {
            IsObtained = false;
            Previous = previous;
            ImagePath1 = Texture.CraftsmanIcon;
            ImagePath2 = Texture.CraftsmanIcon2;
            Title = "РЕМЕСЛЕННИК";
            Description = "Владение инструментом — большое искусство.\n" +
                "Некоторые крафты становятся проще.\n" +
                "Вы получаете небольшой набор ресурсов.\n";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.CraftsmanUpgradeChanges();
                IsObtained = true;
            }
        }
    }
}
