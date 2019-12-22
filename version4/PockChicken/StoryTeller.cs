using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PockChicken.EggBreackers;
using PockChicken.Chicken;
using PockChicken;

namespace PockChicken
{
    
    class StoryTeller
    {
        //Egg goldenEgg;

        Grandpa grandpa;
        Grandma grandma;
        Mouse mouse;

        PockedChicken pockedChicken;

        Generic<Grandpa, Grandma, Mouse> generic;

        public StoryTeller()
        {
            grandpa = new Grandpa();
            grandma = new Grandma();
            mouse = new Mouse();
            pockedChicken = new PockedChicken();
            generic = new Generic<Grandpa, Grandma, Mouse>(grandpa, grandma, mouse);
        }
        public void TellStory()
        {
            Console.WriteLine();
            grandpa.Notify += DisplayMassage;
            grandma.Notify += x => Console.WriteLine(x);
            Egg goldenEgg = pockedChicken.MakeAnEgg();
            if (goldenEgg == null)
                throw new ChikenException("Упс, курочка не снесла яйцо!");
            generic.objectType();
            grandpa.BreakAnEgg(ref goldenEgg);
            if(goldenEgg.Durability > 0)
            {
                grandma.BreakAnEgg(ref goldenEgg);
                if (goldenEgg.Durability > 0)
                {
                    mouse.BreakAnEgg(ref goldenEgg);
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
        public void DisplayMassage(string massage)
        {
            Console.WriteLine(massage);
        }
    }
}
