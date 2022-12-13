using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zuul;

namespace zuul
{
    public class Player 
    {
        private int health;
        public Room CurrentRoom 
        { 
            get; set; 
        }
        public Player() 
        {
            CurrentRoom = null;
            health = 100;
        }
    } 

    
}
