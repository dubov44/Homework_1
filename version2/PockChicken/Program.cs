using PockChicken.Chicken;
using PockChicken.EggBreackers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PockChicken
{
    
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Start(random);
        }
        private static void Start(Random random)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("1 - Начать сказку; 0 - Выйти");
                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.Clear();

                    switch (key.Key)
                    {
                        case ConsoleKey.D0:
                            {
                                return;
                            }
                        case ConsoleKey.D1:
                            {
                                StoryTeller storyTeller = new StoryTeller(random);
                                storyTeller.TellStory();
                                break;
                            }
                        case ConsoleKey.NumPad0:
                            {
                                return;
                            }
                        case ConsoleKey.NumPad1:
                            {
                                StoryTeller storyTeller = new StoryTeller(random);
                                storyTeller.TellStory();
                                break;
                            }
                    }
                }
                catch (ChikenException ex)
                {
                    Console.WriteLine("Ошибка! " + ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (EggBreakerException ex)
                {
                    Console.WriteLine("Ошибка! " + ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }

            }
        }
    }
}
