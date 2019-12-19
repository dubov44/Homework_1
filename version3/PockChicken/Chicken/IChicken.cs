using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken.Chicken
{
    interface IChicken
    {
        Egg MakeAnEgg();
        void EndSpeech();
    }
}
