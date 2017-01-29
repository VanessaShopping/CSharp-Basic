using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClassWork
{
    class ArrayClassWork
    {
        static void Main(string[] args)
        {
            // Задаване на масив   --> тип[] имеНаПроменлива = {
            //                                                  стойност, стойност2 
            //                                                 };

            string[] days = {
                   "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"
            };

            int[] numbers = {
                    1,
                    2,
                    3,
                    4,
                    5,
                    6,
                    7
            };




            // Промяна на стойност в масив
            // имеНаПроменлива[индекс] = новаСтойност;

            days[0] = "Понеделник";

            // Печатане на масив в конзолата

            Console.WriteLine(days[0]);

            

        }
    }
}
