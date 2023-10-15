using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.TkachukSS.Sprint1.Task2.V0.Lib;

namespace Tyuiu.TkachukSS.Sprint1.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #0 | Выполнил: Ткачук С.С | РПСб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Известна длина стороны куба. Вычислить объём куба.                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил Ткачук С.С. | РПСб-23-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int a, b, c;
            Console.WriteLine("Введите значение A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение C: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculateAVGValue(a,b,c));

            Console.ReadLine();
        }
    }
}
