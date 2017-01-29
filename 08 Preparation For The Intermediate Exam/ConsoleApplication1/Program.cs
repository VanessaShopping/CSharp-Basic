using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var maxEven = double.MinValue;
            var minEven = double.MaxValue;
            var maxOdd = double.MinValue;
            var minOdd = double.MaxValue;
            var sumEven = 0.0;
            var sumOdd = 0.0;

            for (int i = 1; i <= num; i++)
            {
                var number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += number;
                    if (number > maxEven)
                    {
                        maxEven = number;
                    }
                    else if (number < minEven)
                    {
                        minEven = number;
                    }
                }
                else
                {
                    sumOdd += number;
                    if (number > maxOdd)
                    {
                        maxOdd = number;
                    }
                    else if (number < minOdd)
                    {
                        minOdd = number;
                    }
                }
            }
            if (num == 0)
            {
                Console.WriteLine("Oddsum = 0");
                Console.WriteLine("Oddmin = No");
                Console.WriteLine("Oddmax = No");
                Console.WriteLine("Evensum = 0");
                Console.WriteLine("Evenmin = No");
                Console.WriteLine("Evenmax = No");
            }
            if (num == 1)
            {
                Console.WriteLine("Oddsum = 1");
                Console.WriteLine("Oddmin = 1");
                Console.WriteLine("Oddmax = 1");
                Console.WriteLine("Evensum = 0");
                Console.WriteLine("Evenmin = No");
                Console.WriteLine("Evenmax = No");
                Console.WriteLine("Oddsum = " + sumOdd);
            }
            else
            {
                Console.WriteLine("Oddsum = " + sumOdd);
                Console.WriteLine("Oddmin = " + minOdd);
                Console.WriteLine("Oddmax = " + maxOdd);
                Console.WriteLine("Evensum = " + sumEven);
                Console.WriteLine("Evenmin = " + minEven);
                Console.WriteLine("Evenmax = " + maxEven);
            }
        }
    }
}