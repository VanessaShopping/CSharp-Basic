using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfThreeDigits
{
    class SumOfThreeDigits
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b == c)
                if (a < b)
                    Console.WriteLine("{0} + {1} = {2}", a, b, c);
                else
                    Console.WriteLine("{0} + {1} = {2}", b, a, c);

            else if (c + a == b)
                if (c < a)
                    Console.WriteLine("{0} + {1} = {2}", c, a, b);
                else
                    Console.WriteLine("{0} + {1} = {2}", a, c, b);

            else if (b + c == a)
                if (b < c)
                    Console.WriteLine("{0} + {1} = {2}", b, c, a);
                else
                    Console.WriteLine("{0} + {1} = {2}", c, b, a);

            else
                Console.WriteLine("No");
        }
    }
}
