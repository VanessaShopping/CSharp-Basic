using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool firstFigure = x >= 2 && x <= 12
                                         &&
                               y >= -3 && y <= 1;
            bool secondFigure = x >= 4 && x <= 10
                                         &&
                               y >= -5 && y <= 3;

            if (firstFigure || secondFigure)
                Console.WriteLine("in");
            else

                Console.WriteLine("out");

            {

            }

        }
    }
}
