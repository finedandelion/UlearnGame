using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Objects;

namespace UlearnGame.Model
{
    public class Game
    {
        public GameField Field;
        public Inventory Inventory;
        public UpgradeSystem UpgradeSystem;
        public CraftStation CraftStation;
        private double LevelConst = 1.1;

        public int ClickPower { get; private set; }
        public int Level { get; private set; }
        public int LevelExperienceCap { get; private set; }
        public double Experience { get; private set; }
        public int TotalCraftTimes { get; private set; }
        public int FieldUpdateRate { get; private set; }
        public int CraftLockFactor { get; private set; }

        public Game()
        {
            ClickPower = 1;
            FieldUpdateRate = 10;
            LevelExperienceCap = 80;
            Field = new GameField();
            Inventory = new Inventory();
            UpgradeSystem = new UpgradeSystem();
            CraftStation = new CraftStation();
        }

        public void AddExperience(double experience)
        {
            Experience += experience;
            if (Experience > LevelExperienceCap && Level < 16)
            {
                Experience = 0;
                Level += 1;
                LevelExperienceCap = (int)(LevelExperienceCap * LevelConst);
            }
        }
    }
}
