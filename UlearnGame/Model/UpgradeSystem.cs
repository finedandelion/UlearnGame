using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Upgrades;

namespace UlearnGame.Model
{
    public class UpgradeSystem
    {
        public readonly Dictionary<int, Upgrade> upgrades;

        public string[] Titles { get; private set; }
        private Game Game { get; set; }
        public int UsedUpgradePoints
        {
            get
            {
                return upgrades.Count(upgrade => upgrade.Value.IsObtained == true);
            }
        }
        public int AvailableUpgradePoints 
        { 
            get 
            {
                return Game.Level - UsedUpgradePoints;
            } 
        }

        public UpgradeSystem(Game game)
        {
            Game = game;
            upgrades = new Dictionary<int, Upgrade>();
            Titles = InitializeTitles();
            InitializeUpgrades();
        }

        private void InitializeUpgrades()
        {
            var gatherer = new GathererUpgrade(Game);
            var craftsman = new CraftsmanUpgrade(Game, new Upgrade[1] { gatherer });
            var master1 = new Master1Upgrade(Game, new Upgrade[1] { craftsman });
            var master2 = new Master2Upgrade(Game, new Upgrade[1] { master1 });
            var master3 = new Master3Upgrade(Game, new Upgrade[1] { master2 });
            var adventurer = new AdventurerUpgrade(Game, new Upgrade[1] { gatherer });
            var archeologist = new ArcheologistUpgrade(Game, new Upgrade[1] { adventurer });
            var hunter = new HunterUpgrade(Game, new Upgrade[1] { gatherer });
            var spelunker = new SpelunkerUpgrade(Game,new Upgrade[2] { hunter, adventurer });
            var explorer = new ExplorerUpgrade(Game,new Upgrade[2] { archeologist, spelunker });
            var magician = new MagicianUpgrade(Game, new Upgrade[1] { gatherer });
            var priest = new PriestUpgrade(Game, new Upgrade[1] { magician });
            var chronomancer = new FormerUpgrade(Game, new Upgrade[2] { priest, spelunker });
            upgrades.Add(0, gatherer);
            upgrades.Add(1, craftsman);
            upgrades.Add(2, master1);
            upgrades.Add(3, master2);
            upgrades.Add(4, master3);
            upgrades.Add(5, adventurer);
            upgrades.Add(6, archeologist);
            upgrades.Add(7, hunter);
            upgrades.Add(8, spelunker);
            upgrades.Add(9, explorer);
            upgrades.Add(10, magician);
            upgrades.Add(11, priest);
            upgrades.Add(12, chronomancer);
        }

        private string[] InitializeTitles()
        {
            return new string[]
            {
                "СУЩНОСТЬ",
                "ПОСЛАННИК",
                "ВЕРУЮЩИЙ",
                "ПРИВЕРЖЕНЕЦ",
                "СЛУЖИТЕЛЬ",
                "ПОДДАННЫЙ",
                "ПРЕДАННЫЙ",
                "ЖРЕЦ",
                "ПРИБЛИЖЁННЫЙ",
                "ПРОСВЯЩЁННЫЙ",
                "АПОСТОЛ",
                "СЛАВЛЕННЫЙ",
                "ВЕЛИКИЙ",
                "БОЖЕСТВО",
            };
        }
    }
}
