using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZamyatinDY.Sprint2.Task0.V1.Lib
{
    public class DataService : ISprint2Task0V1
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y + 111;
            res[1] = x != y + 111;
            res[2] = x < y + 112;
            res[3] = x > y + 114;
            res[4] = x <= y + 113;
            res[5] = x >= y + 114;

            return res;
        }
    }
}
