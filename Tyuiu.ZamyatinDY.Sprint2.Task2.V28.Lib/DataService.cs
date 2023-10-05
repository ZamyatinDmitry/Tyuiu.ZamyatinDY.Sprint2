using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZamyatinDY.Sprint2.Task2.V28.Lib
{
    public class DataService : ISprint2Task2V28
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (((3 <= x && x <= 5) && (3 <= y && y <= 7)) ||
                (x == 2 && (y == 4 || y == 5)) ||
                ((6 <= x && x <= 8) && (5 <= y && y <= 10)) ||
                ((9 <= x && x <= 12) && (y == 5)) ||
                ((10 <= x && x <= 13) && (2 <= y && y <= 3)) ||
                ((10 <= x && x <= 12) && (y == 4)) ||
                ((3 <= x && x <= 12) && (y == 11)) ||
                ((7 <= x && x <= 10) && (y == 12)) ||
                ((x == 13) && (9 <= y && y <= 13)))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
