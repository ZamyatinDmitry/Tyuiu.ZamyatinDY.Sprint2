using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ZamyatinDY.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
    {
        public double FindDateOfNextDay(int g, int m, int n)
        {
            int nextYear = g;
            int nextMonth = m;
            int nextDay = n;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    if (n < 31)
                    {
                        nextDay = n + 1;
                    }
                    else
                    {
                        nextDay = 1;
                        if (m == 12)
                        {
                            nextYear++;
                        }
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (n < 30)
                    {
                        nextDay = n + 1;
                    }
                    else
                    {
                        nextDay = 1;
                    }
                    break;
                case 12:
                    if (n < 31)
                    {
                        nextDay = n + 1;
                    }
                    else
                    {
                        nextDay = 1;
                        nextYear++;
                    }
                    break;
                case 2:
                    if (IsLeapYear(g))
                    {
                        if (n < 29)
                        {
                            nextDay = n + 1;
                        }
                        else
                        {
                            nextDay = 1;
                            nextMonth = 3;
                        }
                    }
                    else
                    {
                        if (n < 28)
                        {
                            nextDay = n + 1;
                        }
                        else
                        {
                            nextDay = 1;
                            nextMonth = 3;
                        }
                    }
                    break;
                default:
                    throw new ArgumentException("Неверный месяц");
            }

            double result = nextYear * 10000 + nextMonth * 100 + nextDay;
            return result;
        }

        private static bool IsLeapYear(int g)
        {
            return (g % 4 == 0 && g % 100 != 0) || (g % 400 == 0);
        }
    }
}
