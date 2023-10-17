using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KasenovAE.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        // a = 185, b = 316, c = 134, d = 134
        // (True, False, False, False, False, False)
        // |, &, ||, &&, !, ^
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c == d);
            res[1] = (a > b) & (c == d);
            res[2] = (a > b) || (c != d);
            res[3] = (a > b) && (c != d);
            res[4] = !(b >= c);
            res[5] = (a > b) ^ (c != d);

            return res;
        }
    }
}
