using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken.EggBreackers
{
    class EggBreakerException : Exception
    {
        public EggBreakerException(string message)
            :base(message)
        {

        }
    }
}
