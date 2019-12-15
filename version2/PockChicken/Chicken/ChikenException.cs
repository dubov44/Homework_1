using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken.Chicken
{
    class ChikenException : Exception
    {
        public ChikenException(string message)
            :base(message)
        {

        }
    }
}
