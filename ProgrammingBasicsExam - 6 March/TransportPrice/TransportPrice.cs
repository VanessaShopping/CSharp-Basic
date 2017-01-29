
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayNight = Console.ReadLine().ToLower();

            if (n < 20)
            {
                if (dayNight == "day")
                    Console.WriteLine((n * 0.79) + 0.7);
                else
                    Console.WriteLine((n * 0.9) + 0.7);
            }
            else if (n < 100)
            {
                Console.WriteLine(n * 0.09);
            }
            else
                Console.WriteLine(n * 0.06);
        }
    }
}
