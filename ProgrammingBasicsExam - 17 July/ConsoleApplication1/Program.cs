using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            double yearToLive = double.Parse(Console.ReadLine());
            double spend = 0;
            double sum1 = 0;
            double sum2 = 0;
            double yearsold = 17;
            double total1 = 0;
            double total2 = 0;
            for (double year = 1800; year <= yearToLive; year++)
            {
                if (year % 2 == 0)
                {
                    spend = 12000;
                    sum1 = sum1 + spend;
                    total1 = heritage - sum1;

                }
                else
                {
                    yearsold += 2;
                    spend = 12000 + 50 * yearsold;
                    sum2 = sum2 + spend;
                    total2 = heritage - sum2;
                }
            }
            if (total2 + total1 >= heritage)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.", (total2 + total1) - heritage);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.", Math.Abs((total2 + total1) - heritage));
            }
        }
    }
}