using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint3.Task5.V5.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Вложенные циклы                                                        *");
            Console.WriteLine("* Задание #5                                                                   *");
            Console.WriteLine("* Вариант #5                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу используя вложенные циклы , которая вычисляет сумму сумм  *");
            Console.WriteLine("*                                3  10                                         *");
            Console.WriteLine("* ряда по формуле, при х=5   y = E   E (x / sin(k))                            *");
            Console.WriteLine("*                               i=1 k=1                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int x = 5;
            int start1 = 1;
            int stop1 = 3;
            int start2 = 1;
            int stop2 = 10;

            Console.WriteLine("Переменная Х = " + x);
            Console.WriteLine("Начало шага первой суммы = " + start1);
            Console.WriteLine("Конец шага первой суммы = " + stop1);
            Console.WriteLine("Начало шага второй суммы = " + start2);
            Console.WriteLine("Конец шага второй суммы = " + stop2);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Сумма сумм ряда = " + ds.GetSumSumSeries(x, start1, start2, stop1, stop2));
            Console.ReadKey();
        }
    }
}
