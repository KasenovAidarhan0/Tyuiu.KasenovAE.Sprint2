using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KasenovAE.Sprint2.Task6.V6.Lib;

namespace Tyuiu.KasenovAE.Sprint2.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Касенов А. Е. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Тернарный оператор                                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Касенов Айдархан Есенаевич | ПКТб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Мастям игральных карт условно присвоены следующие порядковые номера:    *");
            Console.WriteLine("* масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти «червы» — *");
            Console.WriteLine("* 4,  а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13,      *");
            Console.WriteLine("* «тузу» — 14 (порядковые номера карт остальных достоинств соответствуют  *");
            Console.WriteLine("* их названиям: «шестерка», «девятка» и т. п.). По заданным номеру масти  *");
            Console.WriteLine("* m (1 <= m <= 4) и номеру достоинства карты k (6 <= k <= 14) определить  *");
            Console.WriteLine("* полное название (масть и достоинство) соответствующей карты             *");
            Console.WriteLine("* в виде «Дама пик», Шестерка бубен» и т. п.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Номер масти = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Номер достоинства = ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (!(1 <= m && m <= 4) || !(6 <= k && k <= 14))
            {
                Console.WriteLine("Неправильно введены данные");
            }
            else
            {
                DataService ds = new DataService();
                Console.WriteLine(ds.FindCardNameAndValue(m, k));
            }

            Console.ReadKey();
        }
    }
}
