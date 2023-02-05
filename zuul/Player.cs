using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Zuul;

namespace zuul
{

    public class Player
    {
        private int health;

        private Inventory bag;
        public Room CurrentRoom { get; set; }
        public Player()
        {
            CurrentRoom = null;
            health = 100;

            bag = new Inventory(70);
        }

        public int Health
        {
            get { return health; }
            // set { health = value; }
        }
        public void Damage(int amount)
        { health = health - amount; }
        public void Heal(int amount)
        { health = health + amount; }
        public bool IsAlive()
        { return (health > 0); }




       // public string Use(string itemName)
        //{
         //  if itemname = potion 
        //}

            public bool TakeFromCapsule(string itemName)
        {
            Item item = CurrentRoom.Capsule.Get(itemName);

            if (item != null)
            {
                if (this.bag.Put(itemName, item))
                {
                    Console.WriteLine(" you have " + itemName + " in your inventory ") ;
                    return true;
                }
                else {
                    Console.WriteLine(" the " + itemName + " is too big for your bag. ") ;
                    CurrentRoom.Capsule.Put(itemName, item);
                    return false;
                }
            } else {
                Console.WriteLine(" there is no " + itemName + " in this room. ") ;
                return false;
            }
        }
    
        public bool DropToCapsule(string itemName)
        {
            Item item = this.bag.Get(itemName);

            if (item != null)
            {
                CurrentRoom.Capsule.Put(itemName, item);
                Console.WriteLine(" you dropped " + itemName + " from your inventory ");
                return true;
            }
            else
            {
                // Inventory does not contain the specified item, so nothing happens
                Console.WriteLine("Inventory does not contain the specified item...");
                return false;
            }
        }

    }
}