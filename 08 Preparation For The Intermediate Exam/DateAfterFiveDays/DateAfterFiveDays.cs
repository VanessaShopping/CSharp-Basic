using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAfterFiveDays
{
    class DateAfterFiveDays
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            int daysInMonth = 31;
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                daysInMonth = 30;
            }
            if (month == 2)
            {
                daysInMonth = 28;
            }
            int nextDate = day + 5;
            if (nextDate > daysInMonth)
            {
                nextDate = nextDate - daysInMonth;
                month++;
                if (month > 12)
                {
                    month = 01;
                }
            }
            if (month < 10)
                Console.WriteLine("{0}.0{1}", nextDate, month);
            else
                Console.WriteLine("{0}.{1}", nextDate, month);
        }
    }
}
