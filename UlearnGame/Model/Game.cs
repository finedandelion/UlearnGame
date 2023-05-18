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
        public AscendingSystem AscendingSystem;
        public CraftSystem CraftSystem;
        private static double LevelConst = 1.1;

        public int ClickPower { get; private set; }
        public int FieldUpdateRate { get; private set; }
        public int EssenceDrop { get; private set; }
        public int ResourceBonus { get; private set; }
        public int Level { get; private set; }
        public int LevelExperienceCap { get; private set; }
        public double Experience { get; private set; }
        public double TotalExperience { get; private set; }
        public int TotalResourcesDrop { get; private set; }
        public int TotalResourcesCraft { get; private set; }
        public int TotalAscendingTimes { get; private set; }
        public int TotalClickTimes { get; private set; }
        public int TotalObjectDestruction { get; private set; }
        public int TotalCraftTimes { get; private set; }
        public double CapacityHardnessMultiplier { get; private set; }
        public double ExperienceMultiplier { get; private set; }

        public int FirstCraftSimplifier { get; private set; }
        public Game()
        {
            ClickPower = 1;
            FieldUpdateRate = 10;
            LevelExperienceCap = 120;
            CapacityHardnessMultiplier = 1;
            ExperienceMultiplier = 1;
            Field = new GameField(this, 1);
            Inventory = new Inventory();
            UpgradeSystem = new UpgradeSystem(this);
            CraftSystem = new CraftSystem(this);
            AscendingSystem = new AscendingSystem(this);
        }

        public void AddExperience(double experience)
        {
            Experience += experience;
            TotalExperience += experience;
            if (Experience - 1 > LevelExperienceCap && Level < 15)
            {
                while (Experience > LevelExperienceCap && Level < 15)
                {
                    Experience -= LevelExperienceCap;
                    Level += 1;
                    LevelExperienceCap = (int)(LevelExperienceCap * LevelConst);
                }
            }
        }

        public void UpdateTotalClicks()
        {
            TotalClickTimes++;
        }

        public void UpdateTotalCrafts()
        {
            TotalCraftTimes++;
        }

        public void UpdateTotalObjectDestruction()
        {
            TotalObjectDestruction++;
        }

        public void UpdateTotalResourcesDrop(int amount)
        {
            TotalResourcesDrop += amount;
        }

        public void UpdateTotalResourcesCraft(int amount)
        {
            TotalResourcesCraft += amount;
        }

        public void UpdateTotalAscendingTimes()
        {
            TotalAscendingTimes++;
        }

        public void ChangeFieldUpdateRate(int value)
        {
            FieldUpdateRate += value;
        }

        public void ChangeResourceBonus(int value)
        {
            ResourceBonus += value;
        }

        public void ChangeExperienceMultiplier(double value)
        {
            ExperienceMultiplier += value;
        }

        public void ChangeEssenceDrop()
        {
            EssenceDrop++;
        }

        public void CraftsmanUpgradeChanges()
        {
            FirstCraftSimplifier++;
            ClickPower++;
        }
    }
}
