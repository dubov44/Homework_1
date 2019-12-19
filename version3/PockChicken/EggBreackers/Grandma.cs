using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken.EggBreackers
{
    class Grandma : EggBreaker
    {
        public delegate void GrandmaHandler(string massage);
        public event GrandmaHandler Notify;

        Keyboard keyboard;

        private int _lifeExperience = 10;
        private int _force;
        public override int Force
        {
            get { return _force; }
            set { _force = value; }
        }
        public Grandma()
        {
            Force = 10;
            keyboard = new Keyboard();
        }
        public override void BreakAnEgg(ref Egg egg)
        {
            Console.WriteLine("Баба берет яйцо");
            Console.WriteLine("Внимательно отсмотрев яйцо, баба пытается его разбить");
            if (SRandom.GetRandom(1, 5) == 3)
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
                Console.WriteLine("Надо же, у бабы получилось! Вот и сказочке конец...");
                return;
            }
            Console.WriteLine("Баба била, била - не разбила.");

            Console.WriteLine();

            keyboard.GPressKeyY += PressKeyY_Handler;
            keyboard.GPressKeyN += PressKeyN_Handler;

            keyboard.Start(ref egg, "Позволить быбе применить жизненный опыт?(y/n)");

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
            //            egg.Durability -= Force * _lifeExperience;
            //            if (egg.Durability <= 0)
            //            {
            //                Notify?.Invoke($"Яйцо понесло {Force * _lifeExperience} урона, оставшаяся целостность: {egg.Durability}");
            //                Console.WriteLine("Надо же, у бабы получилось! Вот и сказочке конец...");
            //                return;
            //            }
            //            break;
            //        }
            //    default:
            //        {
            //            throw new EggBreakerException("Неправильный выбор!!");
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
            egg.Durability -= Force * _lifeExperience;
            if (egg.Durability <= 0)
            {
                Notify?.Invoke($"Яйцо понесло {Force * _lifeExperience} урона, оставшаяся целостность: {egg.Durability}");
                Console.WriteLine("Надо же, у бабы получилось! Вот и сказочке конец...");
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
