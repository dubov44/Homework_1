using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken.EggBreackers
{
    class Grandma : EggBreaker
    {
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
        }
        public override void BreakAnEgg(ref Egg egg, ref Random random)
        {
            Console.WriteLine("Баба берет яйцо");
            Console.WriteLine("Внимательно отсмотрев яйцо, бабка пытается его разбить");
            egg.Durability -= Force;
            if (random.Next(1, 5) == 3)
                egg.Durability = 0;
            if (egg.Durability <= 0)
            {
                Console.WriteLine("Надо же, у бабы получилось! Вот и сказочке конец...");
                return;
            }
            Console.WriteLine("Баба била, била - не разбила.");

            Console.WriteLine("1 - Позволить бабе применить жизненный опыт; 0 - Положить яйцо на стол");
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
                        egg.Durability -= Force * _lifeExperience;
                        if (egg.Durability <= 0)
                        {
                            Console.WriteLine("Надо же, у бабы получилось! Вот и сказочке конец...");
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
