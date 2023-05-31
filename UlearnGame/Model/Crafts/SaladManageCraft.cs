﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model.Crafts
{
    public class SaladManageCraft : Craft
    {
        public SaladManageCraft(Game game) : base(game)
        {
            Description = "Магические свойства пыли могут помочь с преобразованием блюд.";
        }

        protected override Resource ReturnCraftResult()
        {
            return new Salad() { Amount = 1 };
        }

        protected override Resource[] ReturnCraftResources()
        {
            return new Resource[]
            {
                new Dish() { Amount = 2 },
                new Powder() { Amount = 1 }
            };
        }
    }
}
