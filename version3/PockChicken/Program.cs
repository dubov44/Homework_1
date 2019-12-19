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
        delegate void StartDelegate();
        static void Main(string[] args)
        {
            StartDelegate startDelegate = Start;

            startDelegate();
        }
        private static void Start()
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
                        case ConsoleKey.NumPad0:
                            {
                                return;
                            }
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            {
                                StoryTeller storyTeller = new StoryTeller();
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
