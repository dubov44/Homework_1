using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PockChicken.EggBreackers;
using PockChicken.Chicken;

namespace PockChicken
{
    
    class StoryTeller
    {
        Random random;
        //Egg goldenEgg;

        Grandpa grandpa;
        Grandma grandma;
        Mouse mouse;

        PockedChicken pockedChicken;
        public StoryTeller(Random random)
        {
            this.random = random;
            grandpa = new Grandpa();
            grandma = new Grandma();
            mouse = new Mouse();
            pockedChicken = new PockedChicken();
        }
        public void TellStory()
        {
            Egg goldenEgg = pockedChicken.MakeAnEgg(random);
            if (goldenEgg == null)
                throw new ChikenException("Упс, курочка не снесла яйцо!");
            grandpa.BreakAnEgg(ref goldenEgg, random);
            if(goldenEgg.Durability > 0)
            {
                grandma.BreakAnEgg(ref goldenEgg, random);
                if (goldenEgg.Durability > 0)
                {
                    mouse.BreakAnEgg(ref goldenEgg, random);
                    if(goldenEgg.Durability > 0)
                    {
                        Console.WriteLine("Хм... Что-то пошло не так.");
                        Console.WriteLine("Предлагаю начать заново.");
                        return;
                    }
                    Console.WriteLine("Дед плачет, баба плачет, а курочка кудахчет:");
                    pockedChicken.EndSpeech();
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
