using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Sorting
    {
        ILSA _lsa;
        public void setSortStrategy(ILSA lsa)
        {
            _lsa = lsa;
        }
        public void sort(int[] d)
        {
            _lsa.sort(d);
        }
    }
}
