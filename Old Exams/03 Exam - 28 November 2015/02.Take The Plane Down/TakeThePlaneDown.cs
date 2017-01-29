using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TakeThePlaneDown
{
    class TakeThePlaneDown
    {
        static void Main(string[] args)
        {
            int xHeadquarter = int.Parse(Console.ReadLine());
            int yHeadquarter = int.Parse(Console.ReadLine());
            int borderDistance = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                int xPlane = int.Parse(Console.ReadLine());
                int yPlane = int.Parse(Console.ReadLine());
                bool variantA = xPlane >= xHeadquarter - borderDistance && xPlane <= xHeadquarter + borderDistance;
                bool variantB = yPlane >= yHeadquarter - borderDistance && yPlane <= yHeadquarter + borderDistance;
                bool result = variantA && variantB;
                if (result)
                    Console.WriteLine($"You destroyed a plane at [{xPlane},{yPlane}]");
            }
        }
    }
}
