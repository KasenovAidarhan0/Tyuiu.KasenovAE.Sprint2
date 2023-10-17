using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не
//должна нарушаться) и арифметических выражений, которая вернет логическую последовательность(массив): 
//(True, False, True, False, True, False), при x = 1075, y = 275

namespace Tyuiu.KasenovAE.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y + 800;
            res[1] = x != y + 800;
            res[2] = y < x;
            res[3] = y > x;
            res[4] = y <= x;
            res[5] = y >= x;

            return res;
        }
    }
}
