using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Objects;
using UlearnGame.Resources;

namespace UlearnGame
{
    internal class GameField
    {
        private Dictionary<int, GameObject> Generation;
        private Dictionary<int, GameObject?> Field;
        private int FieldCap { get { return Field.Count - 1; }}
        public GameField()
        {
            Field = new Dictionary<int, GameObject?>() 
            {
                { 0, null},
                { 1, null},
                { 2, null},
                { 3, null}
            };
            Generation = new Dictionary<int, GameObject>()
            {
                { 0, new Tree()}
            };
        }

        public void GenerateResource()
        {
            if (Field.Values.Any(value => value == null))
            {
                var empties = Field.Keys.Where(key => Field[key] == null).ToList();
                var fieldCell = Game.random.Next(0, empties.Count() - 1);
                var gameObejct = Game.random.Next(0, Generation.Count - 1);
                Field[empties[fieldCell]] = Generation[gameObejct];
            }
        }

        public void UpdateObjectState(int clickPower, int fieldCell, Inventory inventory)
        {
            var gameObject = Field[fieldCell];
            if (gameObject != null)
            {
                if (gameObject.ObjectCapacity - clickPower > 0)
                    gameObject.ObjectCapacity -= clickPower;
                else
                {
                    inventory.AddItem(gameObject.ObjectResourceDrop);
                    RemoveObject(fieldCell);
                }
            }
        }

        private void RemoveObject(int fieldCell)
        {
            Field[fieldCell] = null;
        }
    }
}
