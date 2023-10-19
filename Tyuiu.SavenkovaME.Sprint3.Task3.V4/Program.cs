using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavenkovaME.Sprint3.Task3.V4.Lib;

namespace Tyuiu.SavenkovaME.Sprint3.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Савенкова М. Е. | ИИПб-23-2";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #3                                                                    *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                                 *");
            Console.WriteLine("* Задание #3                                                                   *");
            Console.WriteLine("* Вариант #4                                                                   *");
            Console.WriteLine("* Выполнила Савенкова М. Е. | ИИПб-23-2                                        *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Используя цикл foreach удалить из строки все буквы j в строке: plkjjdw cvjkl *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            string value = "plkjjdw cvjkl";
            char item = 'j';
            Console.WriteLine($"Изначальный вид строки: {value}");
            Console.WriteLine($"Буква, которая будет удалена: {item}");

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Полученная строка: " + ds.DeleteCharInString(value, item));
            Console.ReadKey();
        }
    }
}
