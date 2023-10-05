using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZamyatinDY.Sprint2.Task1.V9.Lib
{
    public class DataService : ISprint2Task1V9
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c > d); // 11 > 335 - false, 174 > 478 - false | False
            res[1] = (a < b) & (c > d); // 11 < 335 - true, 174 > 478 - false | False
            res[2] = (a < b) || (c > d); // 11 < 335 - true, 174 > 478 - false | True
            res[3] = (a < b) && (c > d); // 11 < 335 - true, 174 > 478 - false | False
            res[4] = !res[0]; // True
            res[5] = (a > b) ^ (d < c); // 11 > 335 - false, 478 < 174 - false | True

            return res;
        }
    }
}
