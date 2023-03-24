using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());

            // Determine if the year is a leap year
            bool isLeapYear = DateTime.IsLeapYear(year);

            // Iterate over each month of the year
            for (int month = 1; month <= 12; month++)
            {
                // Determine the number of days in the month
                int daysInMonth;
                if (month == 2 && isLeapYear)
                {
                    daysInMonth = 29;
                }
                else if (month == 2)
                {
                    daysInMonth = 28;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    daysInMonth = 30;
                }
                else
                {
                    daysInMonth = 31;
                }

                // Print the month and year
                Console.WriteLine("{0} {1}", GetMonthName( month ) , year);
                Console.WriteLine("Su Mo Tu We Th Fr Sa");

                // Determine the day of the week for the first day of the month
                DateTime firstDayOfMonth = new DateTime(year, month, 1);
                int dayOfWeek = (int)firstDayOfMonth.DayOfWeek;

                // Print the calendar for the month
                for (int day = 1; day <= daysInMonth; day++)
                {
                    if (day == 1)
                    {
                        Console.Write(new string(' ', dayOfWeek * 3));
                    }
                    Console.Write("{0,2} ", day);
                    if ((day + dayOfWeek) % 7 == 0 || day == daysInMonth)
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }

        static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1: return "January";
                case 2: return "February";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "";
            }
        }
    }
}
