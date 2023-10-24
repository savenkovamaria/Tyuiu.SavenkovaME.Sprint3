using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint3.Task6.V27.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task6.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                     *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #27                                                                  *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих числовому  *");
            Console.WriteLine("* отрезку [14, 20] сумму всех делителей больше 9.                              *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            
            int start1 = 14;
            int stop1 = 20;

            Console.WriteLine("Начало отрезка = " + start1);
            Console.WriteLine("Конец отрезка = " + stop1);

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Сумма делителей, больших 9, отрезка = " + ds.GetSumTheDivisors(start1, stop1));
            Console.ReadKey();
        }
    }
}
