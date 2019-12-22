using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken.EggBreackers
{
    class Mouse : EggBreaker
    {
        private int _luck = 100;
        private int _force;
        public override int Force
        {
            get { return _force; }
            set { _force = value; }
        }
        public Mouse()
        {
            Force = 1;
        }
        public override void BreakAnEgg(ref Egg egg)
        {
            Console.WriteLine("Мышка бежит по столу");
            if (SRandom.GetRandom(1, 3) == 1)
                egg.Durability -= Force * _luck;
            if (egg.Durability <= 0)
            {
                Console.WriteLine("Хвостиком задела, яйцо упало и разбилось.");
                return;
            }
            else
            {
                Console.WriteLine("Хвостиком задела, яйцо упало, но не разбилось.");
            }
        }
    }
}
