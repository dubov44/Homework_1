using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PockChicken.EggBreackers
{
    class Grandpa : EggBreaker
    {
        public delegate void GrandpaHandler(string massage);
        public event GrandpaHandler Notify;

        Keyboard keyboard;

        private int _oldStrength = 4;
        private int _force;
        public override int Force
        {
            get { return _force; }
            set { _force = value; }
        }
        public Grandpa()
        {
            Force = 25;
            keyboard = new Keyboard();
        }
        public override void BreakAnEgg(ref Egg egg)
        {
            Console.WriteLine("Дед берет яйцо");
            Console.WriteLine("Внимательно отсмотрев яйцо, дед пытается его разбить");
            if (SRandom.GetRandom(1, 10) == 3)
            {
                Notify?.Invoke($"Яйцо понесло {egg.Durability} урона, оставшаяся целостность: {0}");
                egg.Durability = 0;
            }
            else
            {
                egg.Durability -= Force;
                Notify?.Invoke($"Яйцо понесло {Force} урона, оставшаяся целостность: {egg.Durability}");
            }
            if (egg.Durability <= 0)
            {
                Console.WriteLine("Надо же, у деда получилось! Вот и сказочке конец...");
                return;
            }
            Console.WriteLine("Дед бил, бил - не разбил.");

            
            Console.WriteLine();

            keyboard.GPressKeyY += PressKeyY_Handler;
            keyboard.GPressKeyN += PressKeyN_Handler;

            keyboard.Start(ref egg, "Позволить деду вспомнить былую молодость?(y/n)");

            

            //switch (key.Key)
            //{
            //    case ConsoleKey.D0:
            //    case ConsoleKey.NumPad0:
            //        {
            //            break;
            //        }
            //    case ConsoleKey.D1:
            //    case ConsoleKey.NumPad1:
            //        {
            //            egg.Durability -= Force * _oldStrength;
            //            if (egg.Durability <= 0)
            //            {
            //                Notify?.Invoke($"Яйцо понесло {Force * _oldStrength} урона, оставшаяся целостность: {egg.Durability}");
            //                Console.WriteLine("Надо же, у деда получилось! Вот и сказочке конец...");
            //                return;
            //            }
            //            break;
            //        }
            //    default:
            //        {
            //            throw new EggBreakerException("Неправильный выбор!");
            //            //Console.WriteLine("Неправильный выбор!");
            //            //Console.WriteLine("Яйцо взорвалось!");
            //            //egg.Durability = 0;
            //            //break;
            //        }
            //}
        }
        private void PressKeyY_Handler(ref Egg egg)
        {
            Console.WriteLine();
            egg.Durability -= Force * _oldStrength;
            if (egg.Durability <= 0)
            {
                Notify?.Invoke($"Яйцо понесло {Force * _oldStrength} урона, оставшаяся целостность: {egg.Durability}");
                Console.WriteLine("Надо же, у деда получилось! Вот и сказочке конец...");
                return;
            }
        }
        private void PressKeyN_Handler(ref Egg egg)
        {
            Console.WriteLine();
            return;
        }
    }
}
