using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZamyatinDY.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
       public double FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevG = g;
            int prevM = m;
            int prevN = n;

            switch (m)
            {
                case 1:
                    m = 12;
                    g -= 1;
                    break;
                case 3:
                    if (n == 1)
                    {
                        m = 2;
                        n = 28;

                        if (IsLeapYear(prevG))
                        {
                            n = 29;
                        }
                    }
                    else
                    {
                        m -= 1;
                    }

                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    if (n == 1)
                    {
                        m -= 1;
                        n = 31;
                    }
                    else
                    {
                        n = n - 1;
                    }

                    break;
                case 5:
                case 7:
                case 10:
                case 12:
                    if (n == 1)
                    {
                        m -= 1;
                        n = 30;
                    }
                    else
                    {
                        n = n - 1;
                    }

                    break;
            }

            bool IsLeapYear(int year)
            {
                return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            }

            double result = g * 10000 + m * 100 + n;
            return result;
        }
    }
}
