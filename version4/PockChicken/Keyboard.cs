using PockChicken.Chicken;
using PockChicken.EggBreackers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken
{
    public delegate void PressKeyEventHandler();
    public delegate void GPressKeyEventHandler(ref Egg egg);

    public class Keyboard
    {
        public event PressKeyEventHandler PressKeyY = null;
        public event PressKeyEventHandler PressKeyN = null;
        public event GPressKeyEventHandler GPressKeyY = null;
        public event GPressKeyEventHandler GPressKeyN = null;

        public void PressKeyYEvent()
        {
            if (PressKeyY != null)
            {
                PressKeyY.Invoke();
            }
        }

        public void PressKeyNEvent()
        {
            if (PressKeyN != null)
            {
                PressKeyN.Invoke();
            }
        }
        public void GPressKeyYEvent(ref Egg egg)
        {
            if (GPressKeyY != null)
            {
                GPressKeyY(ref egg);
            }
        }

        public void GPressKeyNEvent(ref Egg egg)
        {
            if (GPressKeyN != null)
            {
                GPressKeyN(ref egg);
            }
        }

        public void Start(string massage)
        {
            while (true)
            {
                try
                {
                   
                Console.WriteLine(massage);

                string s = Console.ReadLine();

                    switch (s)
                    {
                        case "y":
                        case "Y":
                            PressKeyYEvent();
                            return;
                            break;
                        case "n":
                        case "N":
                            PressKeyNEvent();
                            return;
                            break;

                        default:
                            Console.WriteLine("Нет обработчика на {0}", s);
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                }
                catch (ChikenException ex)
                {
                    Console.WriteLine("Ошибка! " + ex.Message);
                    Console.ReadKey();
                    return;
                    //Console.Clear();
                }
                catch (EggBreakerException ex)
                {
                    Console.WriteLine("Ошибка! " + ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        public void Start(ref Egg egg, string massage)
        {
            while (true)
            {
                Console.WriteLine(massage);

                string s = Console.ReadLine();

                switch (s)
                {
                    case "y":
                    case "Y":
                        GPressKeyYEvent(ref egg);
                        return;
                        break;
                    case "n":
                    case "N":
                        GPressKeyNEvent(ref egg);
                        return;
                        break;

                    default:
                        Console.WriteLine("Нет обработчика на {0}", s);
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
