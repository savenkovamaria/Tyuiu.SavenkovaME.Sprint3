using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint3.Task7.V23.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                      *");
            Console.WriteLine("* Задание #7                                                                   *");
            Console.WriteLine("* Вариант #23                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции f(x) на         *");
            Console.WriteLine("* промежутке [-5, 5] с шагом 1. При делении на ноль вернуть значение 0.        *");
            Console.WriteLine("*                                    2 + cos(x)                                *");
            Console.WriteLine("*                 f(x) = 4 - 2 * x + ---------                                 *");
            Console.WriteLine("*                                    2 * x - 2                                 *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int start = -5;
            int stop = 5;
            int len = ds.GetMassFunction(start, stop).Length;
            double[] result = new double[len];
            result = ds.GetMassFunction(start, stop);

            Console.WriteLine("Начало шага = " + start);
            Console.WriteLine("Конец шага = " + stop);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");

            Console.WriteLine("+----------------------------+");
            Console.WriteLine("|      x      |     f(x)     |");
            Console.WriteLine("+----------------------------+");

            for (int i=0; i <= result.Length-1; i++)
            {
                Console.WriteLine("|  {0, 5:d}      |    {1, 5:f2}     |", start, result[i]);
                start++;
            }
            Console.WriteLine("+----------------------------+");
            Console.ReadKey();
        }
    }
}
