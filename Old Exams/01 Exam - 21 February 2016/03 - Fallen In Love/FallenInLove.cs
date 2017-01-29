using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class FallenInLove
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dotFormula = 2;
            int dots = 1;
            int wave = n;
            int midDots = 2 * n;

            topPicture(n);
            dotFormula = topMiddlePicture(n, dotFormula);
            middlePicture(n, ref dots, ref wave, ref midDots);
            bottomPicture(n);
        }

        private static void bottomPicture(int n)
        {
            for (int i = 0; i <= n ; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', n * 2 + 1));
                    Console.Write("####");
                    Console.WriteLine(new string('.', n * 2 + 1));
                }
                else
                {
                    Console.Write(new string('.', n * 2 + 2));
                    Console.Write("##");
                    Console.WriteLine(new string('.', n * 2 + 2));
                }

            }
        }

        private static void middlePicture(int n, ref int dots, ref int wave, ref int midDots)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("#");
                Console.Write(new string('~', wave));
                Console.Write("#");
                Console.Write(new string('.', midDots));
                Console.Write("#");
                Console.Write(new string('~', wave));
                Console.Write("#");
                Console.WriteLine(new string('.', dots));

                dots += 2;
                wave--;
                midDots -= 2;
            }
        }

        private static int topMiddlePicture(int n, int dotFormula)
        {
            for (int i = 1; i < n; i++)
            {
                Console.Write("#");
                Console.Write(new string('~', i));
                Console.Write("#");
                Console.Write(new string('.', 2 * n - dotFormula));
                Console.Write("#");
                Console.Write(new string('.', i * 2));
                Console.Write("#");
                Console.Write(new string('.', 2 * n - dotFormula));
                Console.Write("#");
                Console.Write(new string('~', i));
                Console.WriteLine("#");
                dotFormula += 2;
            }

            return dotFormula;
        }

        private static void topPicture(int n)
        {
            Console.Write("##");
            Console.Write(new string('.', 2 * n));
            Console.Write("##");
            Console.Write(new string('.', 2 * n));
            Console.WriteLine("##");
        }
    }
}
