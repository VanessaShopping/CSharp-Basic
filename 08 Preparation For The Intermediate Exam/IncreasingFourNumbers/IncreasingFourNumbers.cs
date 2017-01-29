using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingFourNumbers
{
    class IncreasingFourNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b - a >= 3)
            {
                for (int n1 = a; n1 <= b; n1++)
                {
                    for (int n2 = n1 + 1; n2 <= b; n2++)
                    {
                        for (int n3 = n2 + 1; n3 <= b; n3++)
                        {
                            for (int n4 = n3 + 1; n4 <= b; n4++)
                            {
                                Console.WriteLine("{0}", n1);
                                Console.WriteLine("{0}", n2);
                                Console.WriteLine("{0}", n3);
                                Console.WriteLine("{0}", n4);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
