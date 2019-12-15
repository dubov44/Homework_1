using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken
{
    public class Egg
    {
        public int Durability { get; set; }
        public Egg()
        {
            Durability = 100;
        }
        public Egg(int durability)
        {
            Durability = durability;
        }
    }
}
