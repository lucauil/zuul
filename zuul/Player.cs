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

        public Inventory Bag { get; }
        public Room CurrentRoom { get; set; }
        public Player()
        {
            CurrentRoom = null;
            health = 100;

            Bag = new Inventory(70);
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




       public string Use(Command command)
        {
            string str = "";
            if (!command.HasSecondWord())
            {
                str = "Use what??";
                return str;
            }
            string itemName = command.GetSecondWord();
           if (itemName == "potion")
           {
                Heal(20);
                str = "You feel much better now";
           }
            return str;
        }

            public bool TakeFromCapsule(string itemName)
            {
                Item item = CurrentRoom.Capsule.Get(itemName);

                if (item != null)
                {
                    if (this.Bag.Put(itemName, item))
                    {
                    Console.WriteLine(" you have " + itemName + " in your inventory ") ;
                    return true;
                    }
                    else 
                    {
                        Console.WriteLine(" the " + itemName + " is too big for your bag. ") ;
                        CurrentRoom.Capsule.Put(itemName, item);
                        return false;
                    }
                }   
                else 
                {
                    Console.WriteLine(" there is no " + itemName + " in this room. ") ;
                    return false;
                }
            }
    
        public bool DropToCapsule(string itemName)
        {
            Item item = this.Bag.Get(itemName);

            if (item != null)
            {
                CurrentRoom.Capsule.Put(itemName, item);
                Console.WriteLine(" you dropped " + itemName + " from your inventory ");
                return true;
            }
            else
            {
                // Inventory does not contain the specified item, so nothing happens
                Console.WriteLine("Your bag does not contain the specified item...");
                return false;
            }
        }

    }
}