using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Zuul
{
    public class Inventory
    {
        private int maxWeight;
        private Collection<Inventory> items;
        public Inventory(int maxWeight)
        {
            this.maxWeight = maxWeight;
            this.items = new Collection<Inventory> ();
        }
        public bool Put(string itemName, Item item)
        {
            // check the Weight of the Item!
            // put Item in the items Collection
            // return true/false for success/failure

            return false;
        }

        public Item Get(string itemName)
        {
            // find Item in items Collection
            // remove Item from items Collection if found
            // return Item

            return null;
        }
    }
}