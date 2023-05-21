using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Blessings
{
    public class SecondChoiceBlessing : Blessing
    {
        public SecondChoiceBlessing(Game game) : base(game)
        {
            LeftDescription = "Все монстры слабеют на 5 ед. прочности";
            RightDescription = "Все монстры становятся сильнее на 10 ед. прочности. +1 к ресурсам.";
        }

        public override void LeftBlessingChanges()
        {
            Game.ChangeMosterState(-5, 0);
        }

        public override void RightBlessingChanges()
        {
            Game.ChangeMosterState(10, 1);
        }
    }
}