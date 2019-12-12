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
        static void Main(string[] args)
        {
            Start();
        }
        private static void Start()
        {
            while (true)
            {
                Random random = new Random();
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
                }
            }
        }
    }
}
