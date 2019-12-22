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
        static void Main(string[] args)
        {
            Dictionary<int, Keyboard> garbage = new Dictionary<int, Keyboard>();
            Keyboard keyboard = new Keyboard();
            int temp = GetNumber();

            keyboard.PressKeyY += PressKeyY_Handler;
            keyboard.PressKeyN += PressKeyN_Handler;
            

            for(int i = 0; i < temp; i++)
            {
                garbage.Add(i + 1, keyboard);
            }

            foreach(var t in garbage)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Попытка #{t.Key} из {garbage.Count}\n");
                Console.ForegroundColor = ConsoleColor.White;
                t.Value.Start("Начать сказку?(y/n)");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        static private void PressKeyY_Handler()
        {
            //Console.Clear();
            StoryTeller storyTeller = new StoryTeller();
            storyTeller.TellStory();
        }
        static private void PressKeyN_Handler()
        {
            Console.WriteLine("Выходим...");
            return;
        }
        static private int GetNumber()
        {
            int number;
            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            bool result = int.TryParse(input, out number);
            if (result == true)
            {
                Console.WriteLine();
                number = int.Parse(input);
                return number;
            } 
            else
            {
                while(result != true)
                {
                    Console.Clear();
                    Console.WriteLine("Введите строку:");
                    input = Console.ReadLine();

                    result = int.TryParse(input, out number);
                }
                Console.WriteLine();
                number = int.Parse(input);
                return number;
            }
        }
        //private static void Start()
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.WriteLine("1 - Начать сказку; 0 - Выйти");
        //            ConsoleKeyInfo key = Console.ReadKey();
        //            Console.Clear();

        //            switch (key.Key)
        //            {
        //                case ConsoleKey.D0:
        //                case ConsoleKey.NumPad0:
        //                    {
        //                        return;
        //                    }
        //                case ConsoleKey.D1:
        //                case ConsoleKey.NumPad1:
        //                    {
        //                        StoryTeller storyTeller = new StoryTeller();
        //                        storyTeller.TellStory();
        //                        break;
        //                    }
        //            }
        //        }
        //        catch (ChikenException ex)
        //        {
        //            Console.WriteLine("Ошибка! " + ex.Message);
        //            Console.ReadKey();
        //            Console.Clear();
        //        }
        //        catch (EggBreakerException ex)
        //        {
        //            Console.WriteLine("Ошибка! " + ex.Message);
        //            Console.ReadKey();
        //            Console.Clear();
        //        }

        //    }
        //}
    }
}
