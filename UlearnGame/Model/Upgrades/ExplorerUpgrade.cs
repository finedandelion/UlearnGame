﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Upgrades
{
    public class ExplorerUpgrade : Upgrade
    {
        public ExplorerUpgrade(Game game, Upgrade[] previous = null)
        {
            IsObtained = false;
            Game = game;
            Previous = previous;
        }

        public override void ObtainUpgrade()
        {
            if (!IsObtained)
            {
                IsObtained = true;
            }
        }
    }
}
