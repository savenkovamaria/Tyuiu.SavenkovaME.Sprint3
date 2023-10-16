using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint3.Task0.V12.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task0.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Алгоритмическая структура цикла for                                    *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #12                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет произведение ряда   *");
            Console.WriteLine("*                              13                                              *");
            Console.WriteLine("* по формуле, при t = 1,   p =  П (t ^ k + 1 / (k + 1)                         *");
            Console.WriteLine("*                              k=1                                             *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");
            double t = 1;
            int start = 1;
            int stop = 13;

            Console.WriteLine($"Переменная t = {t}");
            Console.WriteLine($"Старт шага = {start}");
            Console.WriteLine($"Конец шага = {stop}");                                                             
           
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Произведние ряда = "+ ds.GetSumSeries(t, start, stop));
            Console.ReadKey();

        }
    }
}
