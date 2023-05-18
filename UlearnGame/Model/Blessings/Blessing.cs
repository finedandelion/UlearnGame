using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlearnGame.Model.Blessings
{
    public class Blessing : IBlessing
    {
        public string LeftDescription { get; set; }

        public string RightDescription { get; set; }

        protected Game Game { get; set; }

        public Blessing(Game game)
        {
            Game = game;
        }

        public virtual void LeftBlessingChanges()
        {
            throw new NotImplementedException();
        }

        public virtual void RightBlessingChanges()
        {
            throw new NotImplementedException();
        }
    }
}
