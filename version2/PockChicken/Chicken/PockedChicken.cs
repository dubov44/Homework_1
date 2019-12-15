using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken.Chicken
{
    class PockedChicken : IChicken
    {
        public Egg MakeAnEgg(Random random)
        {
            if (random.Next(1, 5) != 3)
                return new Egg(100);
            return null;
        }
        public void EndSpeech()
        {
            Console.WriteLine("- Не плачь, дед, не плачь, баба: снесу вам яичко не золотое - простое!");
        }
    }
}
