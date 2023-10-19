using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KasenovAE.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1:
                    if (n == 31)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 2:
                    if (n == 28)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 3:
                    if (n == 31)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 4:
                    if (n == 30)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 5:
                    if (n == 31)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 6:
                    if (n == 30)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 7:
                    if (n == 31)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 8:
                    if (n == 31)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 9:
                    if (n == 30)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 10:
                    if (n == 31)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 11:
                    if (n == 30)
                    {
                        n = 0;
                        m++;
                    }
                    n++;
                    break;
                case 12:
                    if (n == 31)
                    {
                        n = 0;
                        m = 1;
                        g++;
                    }
                    n++;
                    break;

            }

            return $"{g}-{m}-{n}";
        }
    }
}
