using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] x = new int[] {1,34,654,234,2534,64 };
            Sorting s = new Sorting();
            s.setSortStrategy(new Selection());
            s.sort(x);
            

        }
    }
}
