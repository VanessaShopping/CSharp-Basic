using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n;
            int underscore = n * 2 - 1;
            int middleNumber = (4 * n - 1 - 5) / 2;
            int dotsBottom = 0;
            int underscoreBottom = n * 4 - 1;

            Solve(n, ref dots, ref underscore, middleNumber, ref dotsBottom, ref underscoreBottom);

        }

        private static void Solve(int n, ref int dots, ref int underscore, int middleNumber, ref int dotsBottom, ref int underscoreBottom)
        {
            Top(n);
            secondTop(n, ref dots, ref underscore);
            middle(middleNumber);
            bottom(n, ref dotsBottom, ref underscoreBottom);
        }

        private static void bottom(int n, ref int dotsBottom, ref int underscoreBottom)
        {
            for (int i = 0; i < n; i++)
            {

                Console.Write(new string('.', dotsBottom));
                Console.Write(@"\\");
                Console.Write(new string('_', underscoreBottom));
                Console.Write(@"//");
                Console.WriteLine(new string('.', dotsBottom));

                dotsBottom++;
                underscoreBottom -= 2;
            }
        }

        private static void middle(int middleNumber)
        {
            Console.Write(@"//");
            Console.Write(new string('_', middleNumber));
            Console.Write("STOP!");
            Console.Write(new string('_', middleNumber));
            Console.WriteLine(@"\\");
        }

        private static void secondTop(int n, ref int dots, ref int underscore)
        {
            for (int i = 1; i <= n; i++)
            {

                Console.Write(new string('.', dots));
                Console.Write(@"//");
                Console.Write(new string('_', underscore));
                Console.Write(@"\\");
                Console.WriteLine(new string('.', dots));

                dots -= 1;
                underscore += 2;

            }
        }

        private static void Top(int n)
        {
            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', n * 2 + 1));
            Console.WriteLine(new string('.', n + 1));
        }
    }
}
