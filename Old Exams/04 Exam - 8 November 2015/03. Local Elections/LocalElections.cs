using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalElections
{
    class LocalElections
    {
        static void Main(string[] args)
        {
            int candidates = int.Parse(Console.ReadLine());
            int elector = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());

            for (int i = 1; i <= candidates; i++)
            {
                string num = i.ToString();
                Console.WriteLine(new string('.', 13));
                plusPicture();
                if (elector == i)
                {
                    if (symbol == 'x' || symbol == 'X')
                    {
                        firstX();
                        secondX(symbol, i, num);
                        thirdX();
                    }
                    if (symbol == 'v' || symbol == 'V')
                    {
                        firstV();
                        secondV(i, num);
                        thirdV(symbol);
                    }
                }
                else
                {

                    emptyFirst();
                    if (i < 10)
                        Console.Write("0" + num);
                    else
                        Console.Write(num);
                    Console.Write(".");
                    Console.Write("|");
                    Console.Write(".....");
                    Console.Write("|");
                    Console.WriteLine("...");
                    emptyFirst();
                }
                plusPicture();
            }
            Console.WriteLine(new string('.', 13));

        }

        private static void emptyFirst()
        {
            Console.Write("...");
            Console.Write("|");
            Console.Write(".....");
            Console.Write("|");
            Console.WriteLine("...");
        }

        private static void secondV(int i, string num)
        {
            if (i < 10)
                Console.Write("0" + num);
            else
                Console.Write(num);
            Console.Write(".");
            Console.Write("|");
            Console.Write(".");
            Console.Write("\\");
            Console.Write(".");
            Console.Write("/");
            Console.Write(".");
            Console.Write("|");
            Console.WriteLine("...");
        }

        private static void secondX(char symbol, int i, string num)
        {
            if (i < 10)
                Console.Write("0" + num);
            else
                Console.Write(num);
            Console.Write(".");
            Console.Write("|");
            Console.Write("..");
            Console.Write("X");
            Console.Write("..");
            Console.Write("|");
            Console.WriteLine("...");
        }

        private static void thirdV(char symbol)
        {
            Console.Write("...");
            Console.Write("|");
            Console.Write("..");
            Console.Write("V");
            Console.Write("..");
            Console.Write("|");
            Console.WriteLine("...");
        }

        private static void firstV()
        {
            Console.Write("...");
            Console.Write("|");
            Console.Write("\\");
            Console.Write("...");
            Console.Write("/");
            Console.Write("|");
            Console.WriteLine("...");
        }

        private static void thirdX()
        {
            Console.Write("...");
            Console.Write("|");
            Console.Write(".");
            Console.Write("/");
            Console.Write(".");
            Console.Write("\\");
            Console.Write(".");
            Console.Write("|");
            Console.WriteLine("...");
        }

        private static void firstX()
        {
            Console.Write("...");
            Console.Write("|");
            Console.Write(".");
            Console.Write("\\");
            Console.Write(".");
            Console.Write("/");
            Console.Write(".");
            Console.Write("|");
            Console.WriteLine("...");
        }

        private static void plusPicture()
        {
            Console.Write(new string('.', 3));
            Console.Write("+");
            Console.Write(new string('-', 5));
            Console.Write("+");
            Console.WriteLine(new string('.', 3));
        }
    }
}
