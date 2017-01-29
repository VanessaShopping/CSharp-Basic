using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int topDots = n - 1;
            int moreDots = n * 3;
            int bottomDots = 1;
            int moreBottomDots = 5 * n - 4;
            int formulaDots = 2 * n + 1;

            topPicture(n);
            TopMiddlePicture(n, ref topDots, ref moreDots);
            Console.WriteLine(new string('*', 5 * n));
            BottomMiddlePicture(n, ref bottomDots, ref moreBottomDots);

            Console.Write(new string('.', formulaDots));
            Console.Write(new string('*', n - 2));
            Console.Write(new string('.', formulaDots));

        }

        private static void BottomMiddlePicture(int n, ref int bottomDots, ref int moreBottomDots)
        {
            if (n % 2 == 0)
            {
                for (int i = 1; i < 2 * n + 1; i++)
                {
                    Console.Write(new string('.', bottomDots));
                    Console.Write("*");
                    Console.Write(new string('.', moreBottomDots));
                    Console.Write("*");
                    Console.WriteLine(new string('.', bottomDots));
                    bottomDots++;
                    moreBottomDots -= 2;
                }
            }
            else
            {
                for (int i = 1; i < 2 * n + 1; i++)
                {
                    Console.Write(new string('.', bottomDots));
                    Console.Write("*");
                    Console.Write(new string('.', moreBottomDots));
                    Console.Write("*");
                    Console.WriteLine(new string('.', bottomDots));
                    bottomDots++;
                    moreBottomDots -= 2;
                }
            }
        }

        private static void TopMiddlePicture(int n, ref int topDots, ref int moreDots)
        {
            for (int i = 1; i < n; i++)
            {

                Console.Write(new string('.', topDots));
                Console.Write("*");
                Console.Write(new string('.', moreDots));
                Console.Write("*");
                Console.WriteLine(new string('.', topDots));
                topDots--;
                moreDots += 2;
            }
        }

        private static void topPicture(int n)
        {
            Console.Write(new string('.', n));
            Console.Write(new string('*', n * 3));
            Console.WriteLine(new string('.', n));
        }
    }
}
