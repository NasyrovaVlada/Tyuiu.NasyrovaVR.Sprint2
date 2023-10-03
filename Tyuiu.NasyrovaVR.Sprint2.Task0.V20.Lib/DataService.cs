using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.NasyrovaVR.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x - 800 == y;
            res[1] = x - 800 != y;
            res[2] = x - 900 < y;
            res[3] = x - 1000 > y;
            res[4] = x - 850 <= y;
            res[5] = x - 900 >= y;

            return res;


        }
    }
}
