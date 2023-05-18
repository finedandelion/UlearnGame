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
            RightDescription = "Все монстры становятся сильнее на 5 ед. прочности. +1 к ресурсам.";
        }

        public override void LeftBlessingChanges()
        {
            
        }

        public override void RightBlessingChanges()
        {
            
        }
    }
}