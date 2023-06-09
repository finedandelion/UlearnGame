﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Visual;

namespace UlearnGame.Model.Upgrades
{
    public class PriestUpgrade : Upgrade
    {
        public PriestUpgrade(Game game, Upgrade[] previous = null) : base(game)
        {
            IsObtained = false;
            Previous = previous;
            ImagePath1 = Texture.PriestIcon;
            ImagePath2 = Texture.PriestIcon2;
            Title = "ЖРЕЦ";
            Description = "Повинуйся и славь своё божество.\n" +
                "На поле появляются обелиски и дары.\n" +
                "Дары содержат один случайный предмет из тех, что требует Божество.\n" +
                "-1c. Taймера.";
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                Game.Field.PriestUpgrade();
                Game.ChangeFieldUpdateRate(-1);
                IsObtained = true;
            }
        }
    }
}
