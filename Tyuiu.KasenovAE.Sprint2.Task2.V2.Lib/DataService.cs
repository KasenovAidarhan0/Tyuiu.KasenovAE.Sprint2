using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KasenovAE.Sprint2.Task2.V2.Lib
{
    public class DataService : ISprint2Task2V2
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            string[] strArr = { "000000000000000",
                                "000000000000000",
                                "001110001101000",
                                "000010001101000",
                                "000011111101000",
                                "001111111101100",
                                "001100011111100",
                                "000000011111100",
                                "000000111111000",
                                "000000011000000",
                                "001111111000000",
                                "000111100000000",
                                "000111100000000",
                                "000000000000000",
                                "000000000000000" };

            string tbh = strArr[y-1];
            if (tbh[x - 1] == '1')
                return true;

            return false;
        }
    }
}
