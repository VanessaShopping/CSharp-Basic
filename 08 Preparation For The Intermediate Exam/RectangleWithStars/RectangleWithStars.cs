using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class RectangleWithStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int midRows = n;
            if (n % 2 == 0)
                midRows--;
            Console.Write(new string('%', 2 * n));
            Console.WriteLine();
            for (int i = 0; i < midRows; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ', n - 2));
                if ((n - 1) / 2 == i)
                    Console.Write("**");
                else
                    Console.Write("  ");
                Console.Write(new string(' ', n - 2));
                Console.Write("%");
                Console.WriteLine();
            }

            Console.Write(new string('%', 2 * n));
        }
    }
}
