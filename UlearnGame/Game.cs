using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Objects;

namespace UlearnGame
{
    internal class Game
    {
        public GameField field;
        public Inventory inventory;

        public int ClickPower { get; private set; }
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public int TotalCraftTimes { get; private set; }
        public int FieldUpdateRate { get; private set; }
        public int CraftLockFactor { get; private set; }

        public Game()
        {
            ClickPower = 1;
            FieldUpdateRate = 10;
            field = new GameField();
            inventory = new Inventory();
        }
    }
}
