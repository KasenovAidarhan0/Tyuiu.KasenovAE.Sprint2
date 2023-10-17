using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KasenovAE.Sprint2.Task3.V7.Lib
{
    public class DataService : ISprint2Task3V7
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x == 0)
                y = (x * x - Math.Cos(x * x) + 10) / (x * x - Math.Sin(x * x) + 12);
            else if (-11 < x && x < 2)
                y = Math.Pow((7 + (1 / (x * x))), 2);
            else if (x < -11)
                y = Math.Pow(x, 4) - 3 / x;
            else if (x > 1)
                y = x * Math.Pow(((x * x + 1) / (x - 1)), x);      

            return Math.Round(y, 3);
        }
    }
}
