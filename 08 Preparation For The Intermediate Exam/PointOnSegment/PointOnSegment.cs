using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class PointOnSegment
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            if (a < b)
            {
                if (x >= a && x <= b)
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }
            else
            {

                if (x <= a && x >= b)
                {
                    Console.WriteLine("in");
                }
                else
                {
                    Console.WriteLine("out");
                }
            }
            int firstResult = Math.Abs(a - x);
            int secondResult = Math.Abs(b - x);
            if (firstResult < secondResult)
            {
                Console.WriteLine(firstResult);
            }
            else
            {
                Console.WriteLine(secondResult);
            }
        }
    }
}
