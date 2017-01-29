using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            topPicutre(n);
            middlePicture(n);
            bottomPicture(n);
        }

        private static void topPicutre(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                TopLeftRightPicture(n, i);

                Console.Write(@"\ /");

                TopLeftRightPicture(n, i);

                Console.WriteLine();
            }
        }

        private static void bottomPicture(int n)
        {
            for (int i = 1; i <= n - 2; i++)
            {
                TopLeftRightPicture(n, i);

                Console.Write(@"/ \");

                TopLeftRightPicture(n, i);

                Console.WriteLine();
            }
        }

        private static void middlePicture(int n)
        {
            Console.Write(new string(' ', n - 1));
            Console.Write("@");
            Console.WriteLine(new string(' ', n - 1));
        }

        private static void TopLeftRightPicture(int n, int i)
        {
            if (i % 2 == 0)
                Console.Write(new string('-', n - 2));
            else
                Console.Write(new string('*', n - 2));
        }
    }
}
