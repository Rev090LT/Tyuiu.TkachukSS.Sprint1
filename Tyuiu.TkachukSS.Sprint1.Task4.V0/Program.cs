using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint1.Task4.V0.Lib;

namespace Tyuiu.TkachukSS.Sprint1.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Ткачук С.С | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, " +
                                 "вычисляет результат по формуле и печатает его на экране                *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил Ткачук С.С. | РПСб-23-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("* Введите X:                                                              *");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("* Введите Y:                                                              *");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();

        }
    }
}
