using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint2.Task5.V11.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
            Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число).                       *");
            Console.WriteLine("* По заданным g, n и m определить дату следующего дня.                    *");
            Console.WriteLine("* Заданный год не является високосным.                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Год = ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Месяц = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (g % 400 == 0 ^ (g % 100 != 0 && g % 4 == 0))
            {
                Console.WriteLine("Введеный год является високосным");
            }
            else
            {
                DataService ds = new DataService();
                Console.WriteLine(ds.FindDateOfNextDay(g, m ,n));
            }

            Console.ReadKey();
        }
    }
}
