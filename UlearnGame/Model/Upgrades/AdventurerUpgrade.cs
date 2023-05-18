using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class AdventurerUpgrade : Upgrade
    {
        public AdventurerUpgrade(Game game, Upgrade[] previous = null)
        {
            IsObtained = false;
            Game = game;
            Previous = previous;
            ImagePath1 = Texture.AdventurerIcon;
            ImagePath2 = Texture.AdventurerIcon2;
            Title = "АВАНТЮРИСТ";
            Description = "Новые земли ждут вас!\n" +
                "Расширяет игровое поле на две клетки.\n" +
                "На поле появляются руды.\n" +
                "+1 к количеству собираемых ресурсов.";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained) 
            {
                Game.ChangeResourceBonus(1);
                Game.Field.AdventurerUpgrade();
                IsObtained = true;
            }
        }
    }
}
