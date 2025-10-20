using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreVsConsolas
{
    internal class Canon
    {
        public int RoundType(int count)
        {
            if (count % 3 == 0) { return 3; }
            if (count % 5 == 0) { return 5; }
            return 1;
        }
    }
}
