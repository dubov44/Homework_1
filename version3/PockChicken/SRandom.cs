﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken
{
    static class SRandom
    {
        private static Random _random = new Random();
        public static int GetRandom(int min, int max)
        {
            return _random.Next(min, max);
        }
    }
}
