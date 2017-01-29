using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            string[] days =
                {
                    "Monday",
                    "Tuesday",
                    "Wednesday",
                    "Thursday",
                    "Friday",
                    "Saturday",
                    "Sunday"
                };
            Console.WriteLine("days[6] = " + days[6]);

            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            Console.WriteLine("months[11] = " + months[11]);

            Console.Write("Enter a number n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("days[n-1] = " + days[n - 1]);

            Console.WriteLine("days.lenght = " + days.Length);
            Console.WriteLine("motnh.lenght = " + months.Length);




            int a = int.Parse(Console.ReadLine());
            bool[] primes = new bool[a + 1];

            for (int i = 2; i <= a; i++)
                primes[i] = true;

            for (int num = 2; num <= a; num++)
            {
                if (primes[num])
                {

                    Console.WriteLine(num);
                    int step = num * 2;
                    while (step <= a)
                    {
                        primes[step] = false;
                        step += num;
                    }
                }
            }



        }
    }
}
