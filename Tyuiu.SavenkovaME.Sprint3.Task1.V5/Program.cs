using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint3.Task1.V5.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Оператор цикла while                                                   *");
            Console.WriteLine("* Задание #1                                                                   *");
            Console.WriteLine("* Вариант #5                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение ряда *");
            Console.WriteLine("*                   10                                                         *");
            Console.WriteLine("* по формуле   p =  П (cos(0,1) + (k) ^ -2)                                    *");
            Console.WriteLine("*                  k=1                                                         *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int start = 1;
            int stop = 10;

            Console.WriteLine($"Старт шага = {start}");
            Console.WriteLine($"Конец шага = {stop}");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Произведние ряда = " + ds.GetMultiplySeries(start, stop));
            Console.ReadKey();
        }
    }
}
