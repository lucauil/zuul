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
        public bool IsAlive()
        { return (health > 0); }





        public bool TakeFromCapsule(string itemName)
        {

            return false;
        }
        public bool DropToCapsule(string itemName)
        {
            return false;
        }

    }
}