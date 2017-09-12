using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class TimeLoop
    {
        public static string Display()
        {
            DateTime dt = DateTime.Parse("11/16/1993 05:40");
            DateTime Present = DateTime.Now;

            int Year = Present.Year - dt.Year - 1;
            int Day = 0;
            int Month = 0;

            if (Present.Day >= 16)
            {
                Month = Present.Month + 1;
                Day = Present.Day - 16;
            }
            else if (Present.Day < 16)
            {
                Month = Present.Month;
                Day = GetMonthDay() - 16 + Present.Day;
            }

            if (Month == 13)
            {
                Year = Year + 1;
                Month = 1;
            }

            return string.Format("{0} years, {1} Months, {2} Days {3: HH:mm:ss}", Year, Month, Day, new DateTime(1, 1, 1, Math.Abs(Present.Hour - dt.Hour), Math.Abs(Present.Minute - dt.Minute),Present.Second ));
        }

        public static int GetMonthDay(DateTime? opt = null)
        {
            int year = opt != null ? DateTime.Parse(opt.ToString()).Year : DateTime.Now.Year;
            int month = opt != null ? DateTime.Parse(opt.ToString()).Month : DateTime.Now.Month;
            int days = 0;

            int[] leap = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 1)
                days = leap[11];
            else
                days = leap[month - 2];

            if (year % 4 == 0 && year % 100 != 0)
            {
                if (month == 2)
                    days = 29;
            }
            else if (year % 400 == 0)
            {
                if (month == 2)
                    days = 29;
            }

            return days;
        }
    }
}
