using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int symbol = n / 2;
            int bottomUnderscore = n / 2;
            int middleUnderscore = (n * 2 - 4) - (symbol * 2);
            int bottomSpaces = (n * 2 - middleUnderscore - 2) / 2;
            int spaces = n * 2 - 2;
            int bottomSpace = (2 * n - 4) - 2 * bottomUnderscore;


            topPicture(symbol, middleUnderscore);
            middlePicture(n, middleUnderscore, bottomSpaces, spaces);
            bottomPicture(bottomUnderscore, bottomSpace);

        }

        private static void bottomPicture(int bottomUnderscore, int bottomSpace)
        {
            Console.Write(@"\");
            Console.Write(new string('_', bottomUnderscore));
            Console.Write(@"/");
            Console.Write(new string(' ', bottomSpace));
            Console.Write(@"\");
            Console.Write(new string('_', bottomUnderscore));
            Console.Write(@"/");
        }

        private static void middlePicture(int n, int middleUnderscore, int bottomSpaces, int spaces)
        {
            if (n < 5)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(@"|");
                    Console.Write(new string(' ', spaces));
                    Console.WriteLine(@"|");
                }
            }
            else
            {
                for (int i = 0; i < n - 3; i++)
                {
                    Console.Write(@"|");
                    Console.Write(new string(' ', spaces));
                    Console.WriteLine(@"|");
                }
                Console.Write(@"|");
                Console.Write(new string(' ', bottomSpaces));
                Console.Write(new string('_', middleUnderscore));
                Console.Write(new string(' ', bottomSpaces));
                Console.WriteLine(@"|");
            }
        }

        private static void topPicture(int symbol, int middleUnderscore)
        {
            Console.Write(@"/");
            Console.Write(new string('^', symbol));
            Console.Write(@"\");
            Console.Write(new string('_', middleUnderscore));
            Console.Write(@"/");
            Console.Write(new string('^', symbol));
            Console.WriteLine(@"\");
        }
    }
}
