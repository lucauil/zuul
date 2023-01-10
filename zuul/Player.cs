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
        public Room CurrentRoom { get; set; }
        public Player()
        {
            CurrentRoom = null;
            health = 100;
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

    }
    private Inventory bag; 
    public Player()
    {// 25kg is pretty heavy to carry around all day.
     bag = new Inventory(70);
    }
    
    public bool TakeFromChest(string itemName)
    {
        
         return false;
    }
    public bool DropToChest(string itemName)
    {
       return false;}

    }
