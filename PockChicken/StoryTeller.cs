using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PockChicken.EggBreackers;

namespace PockChicken
{
    
    class StoryTeller
    {
        Random random;
        Egg goldenEgg;

        Grandpa grandpa;
        Grandma grandma;
        Mouse mouse;
        public StoryTeller(Random random)
        {
            this.random = random;
            goldenEgg = new Egg();
            grandpa = new Grandpa();
            grandma = new Grandma();
            mouse = new Mouse();
        }
        public void TellStory()
        {
            grandpa.BreakAnEgg(ref goldenEgg, ref random);
            if(goldenEgg.Durability > 0)
            {
                grandma.BreakAnEgg(ref goldenEgg, ref random);
                if (goldenEgg.Durability > 0)
                {
                    mouse.BreakAnEgg(ref goldenEgg, ref random);
                    if(goldenEgg.Durability > 0)
                    {
                        Console.WriteLine("Хм... Что-то пошло не так.");
                        Console.WriteLine("Предлагаю начать заново.");
                        return;
                    }
                    Console.WriteLine("Дед плачет, баба плачет, а курочка кудахчет:");
                    Console.WriteLine("- Не плачь, дед, не плачь, баба: снесу вам яичко не золотое - простое!");
                    return;
                }
                else
                {
                    Console.WriteLine("Хм... Что-то пошло не так.");
                    Console.WriteLine("Предлагаю начать заново.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Хм... Что-то пошло не так.");
                Console.WriteLine("Предлагаю начать заново.");
                return;
            }
        }

    }
}
