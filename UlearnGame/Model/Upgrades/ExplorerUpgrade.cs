using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class ExplorerUpgrade : Upgrade
    {
        public ExplorerUpgrade(Game game, Upgrade[] previous = null)
        {
            IsObtained = false;
            Game = game;
            Previous = previous;
            ImagePath1 = Texture.ExplorerIcon;
            ImagePath2 = Texture.ExplorerIcon2;
            Title = "ИССЛЕДОВАТЕЛЬ";
            Description = "Не существует мест, где бы вы не бывали.\n" +
                "Расширяет игровое поле на три клетки.\n" +
                "-1с. Таймера.\n" +
                "+20% шанс появления доп. объекта на поле.";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.Field.ExplorerUpgrade();
                Game.ChangeFieldUpdateRate(-1);
                Game.Field.ChangeDoubleGenerationChance(0.2);
                IsObtained = true;
            }
        }
    }
}
