using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Will_there_be_enough_space
{
    public static class Kata
    {
        public static int Enough(int cap, int on, int wait)
        {
            return (cap - on - wait) >= 0 ? 0 : on + wait - cap;
        }
    }
}
