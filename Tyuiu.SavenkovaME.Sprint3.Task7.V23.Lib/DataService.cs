using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SavenkovaME.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            double y;
            int len = (stopValue - startValue) + 1;
            double[] func = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round(4 - 2 * x + ((2 + Math.Cos(x)) / (2 * x - 2)), 2);
                func[count] = y;
                count++;
                if (x == 1)
                {
                    func[6] = 0.00;
                }
            }
            return func;
        }
    }
}
