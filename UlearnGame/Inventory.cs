using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using UlearnGame.Resources;
namespace UlearnGame
{
    internal class Inventory
    {
        private Dictionary<Type, Resource> storage = new Dictionary<Type, Resource>();

        public void AddItem(Resource resource)
        {
            var type = resource.GetType();
            if (storage.TryGetValue(type, out var value))
                storage[type].Amount += resource.Amount;
            else
                storage.Add(type, resource);
        }

        public bool UseItem(Resource resource)
        {
            var type = resource.GetType();
            if (!storage.TryGetValue(type, out var value)
                || value.Amount - resource.Amount < 0)
                return false;
            storage[type].Amount -= resource.Amount;
            if (storage[type].Amount == 0)
                RemoveItem(value);
            return true;
        }

        public void RemoveItem(Resource resource)
        {
            storage.Remove(resource.GetType());
        }

        public List<Resource> ShowStorage()
        {
            return storage
                .OrderBy(element => element.Key)
                .Select(element => element.Value)
                .ToList();
        }

        public Resource[] GetStorage()
        {
            return storage
                .Select(element => element.Value)
                .ToArray();
        }

        public Dictionary<Type, Resource> ReturnStorage()
        {
            return storage;
        }

    }
}
