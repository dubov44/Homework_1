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
        }
        public override void BreakAnEgg(ref Egg egg, ref Random random)
        {
            Console.WriteLine("Дед берет яйцо");
            Console.WriteLine("Внимательно отсмотрев яйцо, дед пытается его разбить");
            egg.Durability -= Force;
            if (random.Next(1, 10) == 3)
                egg.Durability = 0;
            if(egg.Durability <= 0)
            {
                Console.WriteLine("Надо же, у деда получилось! Вот и сказочке конец...");
                return;
            }
            Console.WriteLine("Дед бил, бил - не разбил.");

            Console.WriteLine("1 - Позволить деду вспомнить былую молодость; 0 - Дать яйцо бабке");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            switch (key.Key)
            {
                case ConsoleKey.D0:
                    {
                        break;
                    }
                case ConsoleKey.D1:
                    {
                        egg.Durability -= Force * _oldStrength;
                        if (egg.Durability <= 0)
                        {
                            Console.WriteLine("Надо же, у деда получилось! Вот и сказочке конец...");
                            return;
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Неправильный выбор!");
                        Console.WriteLine("Яйцо взорвалось!");
                        egg.Durability = 0;
                        break;
                    }
            }
        }
    }
}
