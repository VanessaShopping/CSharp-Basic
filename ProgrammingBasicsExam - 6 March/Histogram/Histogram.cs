using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;


            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                    p1++;
                else if (number >= 200 && number <= 399)
                    p2++;
                else if (number >= 400 && number <= 599)
                    p3++;
                else if (number >= 600 && number <= 799)
                    p4++;
                else if (number >= 800)
                    p5++;
            }
            double p1Percent = (p1 / n) * 100.0;
            double p2Percent = (p2 / n) * 100.0;
            double p3Percent = (p3 / n) * 100.0;
            double p4Percent = (p4 / n) * 100.0;
            double p5Percent = (p5 / n) * 100.0;

            Console.WriteLine($"{p1Percent:F2}%");
            Console.WriteLine($"{p2Percent:F2}%");
            Console.WriteLine($"{p3Percent:F2}%");
            Console.WriteLine($"{p4Percent:F2}%");
            Console.WriteLine($"{p5Percent:F2}%");



        }
    }
}
