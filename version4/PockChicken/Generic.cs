using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PockChicken
{
    class Generic<TGranp, TGranm, TMouse>
    {
        TGranp _gr;
        TGranm _grm;
        TMouse _ms;

        public Generic(TGranp gr, TGranm grm, TMouse ms)
        {
            _gr = gr;
            _grm = grm;
            _ms = ms;
        }

        public void objectType()
        {
            Console.WriteLine("Герои сказки: " + "\n1 - " +  typeof(TGranp)
                + "\n2 - " + typeof(TGranm) + "\n3 - " + typeof(TMouse));
            Console.WriteLine();
        }
    }
}
