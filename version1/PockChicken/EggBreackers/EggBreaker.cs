using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken.EggBreackers
{
    abstract class EggBreaker
    {
        public abstract int Force { get; set; }
        public abstract void BreakAnEgg(ref Egg egg, ref Random random);
    }
}
