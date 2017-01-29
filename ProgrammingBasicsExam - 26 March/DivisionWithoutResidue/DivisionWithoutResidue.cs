using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionWithoutResidue
{
    class DivisionWithoutResidue
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double divideByTwo = 0.0;
            double divideByThree = 0.0;
            double divideByFour = 0.0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                    divideByTwo++;
                if (number % 3 == 0)
                    divideByThree++;
                if (number % 4 == 0)
                    divideByFour++;
            }

            double p1 = (double)((divideByTwo / n) * 100);
            double p2 = (double)((divideByThree / n) * 100);
            double p3 = (double)((divideByFour / n) * 100);

            Console.WriteLine("{0:F2}%", p1);
            Console.WriteLine("{0:F2}%", p2);
            Console.WriteLine("{0:F2}%", p3);



        }
    }
}
