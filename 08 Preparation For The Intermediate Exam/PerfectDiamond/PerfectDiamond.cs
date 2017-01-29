using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class PerfectDiamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int space = 0; space < n - row; space++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int lineStar = 0; lineStar < row - 1; lineStar++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

            for (int s = 1; s <= n - 1; s++)
            {
                for (int space = 0; space < s; space++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int lineStar = n - 2; lineStar >= s; lineStar--)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
