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
        private Random Random = new Random();
        private Dictionary<int, GameObject> Generation;
        public Dictionary<int, GameObject?> Field { get; private set; }
        public int FieldCap { get { return Field.Count - 1; }}
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
                { 0, new Func<GameObject>(() => new Tree()).Invoke()}
            };
        }

        public int? GenerateResource()
        {
            if (Field.Values.Any(value => value == null))
            {
                var empties = Field.Keys.Where(key => Field[key] == null).ToArray();
                var fieldCell = Random.Next(0, empties.Length - 1);
                var gameObejct = Random.Next(0, Generation.Count - 1);
                Field[empties[fieldCell]] = Generation[gameObejct];
                return empties[fieldCell];
            }
            return null;
        }

        public bool UpdateObjectState(int clickPower, int fieldCell, Inventory inventory)
        {
            var gameObject = Field[fieldCell];
            if (gameObject != null)
            {
                if (gameObject.Capacity - clickPower > 0)
                    gameObject.ChangeState(clickPower);
                else
                {
                    inventory.AddItem(gameObject.ResourcesDrop);
                    RemoveObject(fieldCell);
                    return true;
                }
            }
            return false;
        }

        public void ExtendField(int extendTimes)
        {
            while (extendTimes-- > 0)
                Field.Add(FieldCap + 1, null);
        }

        private void RemoveObject(int fieldCell)
        {
            Field[fieldCell] = null;
        }


    }
}
