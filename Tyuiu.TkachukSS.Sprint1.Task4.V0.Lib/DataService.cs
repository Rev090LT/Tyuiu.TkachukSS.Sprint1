using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TkachukSS.Sprint1.Task4.V0.Lib
{
    public class DataService : ISprint1Task4V5
    {
        public double Calculate(double x, double y)
        {
            var res = (x + Math.Pow(y, 2)) / Math.Exp(2 - 4 * y);
            return res;
        }
    }
}
