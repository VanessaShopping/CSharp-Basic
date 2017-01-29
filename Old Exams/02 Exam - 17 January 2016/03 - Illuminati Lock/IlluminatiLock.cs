using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlluminatiLock
{
    class IlluminatiLock
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int formula = (n - 5) / 2;
            int middleFormula = ((n + 1) - 6) / 2;
            int secondDots = 2;
            int bottomSecondDots = secondDots + 1;
            int centerDots = n - 2;
            int dots = (n * 3 - 7 - secondDots - centerDots) / 2;
            int bottomDots = dots - 1;

            TopBottomPicture(n);
            SecondPenultimatePicture(n);
            secondPicture(middleFormula, ref secondDots, centerDots, ref dots);
            MiddlePicture(n);
            MiddlePicture(n);
            bottomPicture(middleFormula, ref bottomSecondDots, centerDots, ref bottomDots);
            SecondPenultimatePicture(n);
            TopBottomPicture(n);

        }

        private static void bottomPicture(int middleFormula, ref int bottomSecondDots, int centerDots, ref int bottomDots)
        {
            for (int i = 0; i < middleFormula; i++)
            {
                Console.Write(new string('.', bottomSecondDots));
                Console.Write("##");
                Console.Write(new string('.', bottomDots));
                Console.Write("#");
                Console.Write(new string('.', centerDots));
                Console.Write("#");
                Console.Write(new string('.', bottomDots));
                Console.Write("##");
                Console.WriteLine(new string('.', bottomSecondDots));
                bottomDots -= 2;
                bottomSecondDots += 2;
            }
        }

        private static void secondPicture(int middleFormula, ref int secondDots, int centerDots, ref int dots)
        {
            for (int i = 0; i < middleFormula; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("##");
                Console.Write(new string('.', secondDots));
                Console.Write("#");
                Console.Write(new string('.', centerDots));
                Console.Write("#");
                Console.Write(new string('.', secondDots));
                Console.Write("##");
                Console.WriteLine(new string('.', dots));
                dots -= 2;
                secondDots += 2;
            }
        }

        private static void MiddlePicture(int n)
        {
            Console.Write('.');
            Console.Write(new string('#', 2));
            Console.Write(new string('.', n - 3));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', n - 2));
            Console.Write(new string('#', 1));
            Console.Write(new string('.', n - 3));
            Console.Write(new string('#', 2));
            Console.WriteLine('.');
        }

        private static void SecondPenultimatePicture(int n)
        {
            Console.Write(new string('.', n - 2));
            Console.Write(new string('#', 3));
            Console.Write(new string('.', n - 2));
            Console.Write(new string('#', 3));
            Console.WriteLine(new string('.', n - 2));
        }

        private static void TopBottomPicture(int n)
        {
            Console.Write(new string('.', n));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', n));
        }
    }
}
