// Sharov Andrei group 124/11
using DayMonthException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeapYear
{

    enum MonthName
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class DayMonthException
    {


        static void Main(string[] args)
        {

            try
            {
                Console.Write("Please enter the year: ");
                int yearNum = int.Parse(Console.ReadLine());
                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                //if (isLeapYear)
                //{
                //    Console.WriteLine(" IS a leap year");
                //}
                //else
                //{
                //    Console.WriteLine(" is NOT a leap year");
                //}
                int maxDayNum = isLeapYear ? 366 : 365;
                Console.Write($"Please enter a day number between 1 and {maxDayNum}: ");
                int dayNum = int.Parse(Console.ReadLine());
                if (dayNum < 1 || dayNum > maxDayNum)
                {
                    throw new ArgumentOutOfRangeException("Day out of range");
                }

                //Console.WriteLine($"{maxDayNum}");
                List<int> DaysInMonths = [31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
                List<int> DaysInLeapMonths = [31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31];
                int monthNum = 0;
                if (isLeapYear)
                {
                    foreach (int daysInMonth in DaysInLeapMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                else
                {
                    foreach (int daysInMonth in DaysInMonths)
                    {
                        if (dayNum <= daysInMonth)
                        {
                            break;
                        }
                        else
                        {
                            dayNum -= daysInMonth;
                            monthNum++;
                        }
                    }
                }
                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();
                Console.WriteLine("{0} {1}", dayNum, monthName);
            }
            catch (Exception caught)
            {
                Console.WriteLine(caught);
            }
        }
    }
}


