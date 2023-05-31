using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Model.Objects;
using UlearnGame.Model.Resources;

namespace UlearnGame.Model
{
    public class GameField
    {
        private Dictionary<int, Func<GameObject>> Generation;
        private int DoubledGeneration;

        public Dictionary<int, GameObject?> GameCells { get; private set; }
        public int FieldCap { get { return GameCells.Count - 1; } }
        public double DoubleGenrationChances { get; private set; }
        public int GenerationTimes => (new Random().NextDouble() < DoubleGenrationChances ? 2 : 1) * DoubledGeneration;
        private Game Game { get; set; }
        public GameField(Game game, int startResources)
        {
            Game = game;
            DoubledGeneration = 1;
            GameCells = new Dictionary<int, GameObject?>()
            {
                { 0, null},
                { 1, null},
                { 2, null},
                { 3, null}
            };
            Generation = new Dictionary<int, Func<GameObject>>()
            {
                { 0, new Func<GameObject>(() => new Tree(Game))},
                { 1, new Func<GameObject>(() => new Stone(Game))},
            };
            while (startResources-- > 0)
                GenerateResource();
        }

        public int?[] GenerateResource()
        {
            var generationTimes = GenerationTimes;
            var indexes = new int?[generationTimes];
            for (var i = 0; i < generationTimes; i++)
            {
                if (GameCells.Values.Any(value => value == null))
                {
                    var empties = GameCells.Keys.Where(key => GameCells[key] == null).ToArray();
                    var fieldCell = new Random().Next(0, empties.Length);
                    var gameObejct = new Random().Next(0, Generation.Count);
                    GameCells[empties[fieldCell]] = Generation[gameObejct].Invoke();
                    indexes[i] = empties[fieldCell];
                }
                else
                    indexes[i] = null;
            }
            return indexes;
        }

        public bool UpdateObjectState(int fieldCell)
        {
            var gameObject = GameCells[fieldCell];
            if (gameObject != null)
            {
                Game.UpdateTotalClicks();
                if (gameObject.Capacity - Game.ClickPower > 0)
                    gameObject.ChangeState();
                else
                {
                    var drop = gameObject.ResourcesDrop;
                    gameObject.GainExperience();
                    Game.Inventory.AddItem(drop);
                    RemoveObject(fieldCell);
                    foreach (var res in drop)
                        Game.UpdateTotalResourcesDrop(res.Amount);
                    Game.UpdateTotalObjectDestruction();
                    return true;
                }
            }
            return false;
        }

        public void ExtendField(int extendTimes)
        {
            while (extendTimes-- > 0)
                GameCells.Add(FieldCap + 1, null);
        }

        private void RemoveObject(int fieldCell)
        {
            GameCells[fieldCell] = null;
        }

        public void ChangeDoubleGenerationChance(double value)
        {
            DoubleGenrationChances += value;
        }

        public void GathererUpgrade()
        {
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Bush(Game)));
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Flower(Game)));
        }

        public void AdventurerUpgrade()
        {
            ExtendField(2);
            ChangeDoubleGenerationChance(0.1);
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Iron(Game)));
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Gold(Game)));
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Coal(Game)));

        }
        
        public void ArcheologistUpgrade()
        {
            ExtendField(3);
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Sandstone(Game)));
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Remains(Game)));
        }

        public void ExplorerUpgrade()
        {
            ExtendField(3);
        }

        public void HunterUpgrade()
        {
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Slime(Game)));
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Deer(Game)));
        }

        public void SpelunkerUpgrade()
        {
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Bat(Game)));
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Crystal(Game)));
        }

        public void MagicianUpgrade()
        {
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Star(Game)));
        }

        public void SlateBlessing()
        {
            Generation[1] = new Func<GameObject>(() => new Slate(Game));
        }

        public void LivingTreeBlessing()
        {
            Generation[0] = new Func<GameObject>(() => new LivingTree(Game));
        }

        public void PriestUpgrade()
        {
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Obelisk(Game)));
            Generation.Add(Generation.Count, new Func<GameObject>(() => new Gift(Game)));
        }

        public void FormerUpgrade()
        {
            SetDoubledGeneration();
        }

        private void SetDoubledGeneration()
        {
            DoubledGeneration++;
        }
    }
}
