using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceOfDiamonds
{
    class AceOfDiamonds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int line = (n - 3) / 2;

            Console.WriteLine(new string('*', n));

            while (a <= n - 2)
            {
                Console.Write("*");
                Console.Write(new string('-', line));
                Console.Write(new string('@', a));
                Console.Write(new string('-', line));
                Console.WriteLine("*");
                a += 2;
                line--;
            }
            //Console.WriteLine(a);
            line += 2;
            a -= 2;
            //Console.WriteLine(a);

            while (a != 1)
            {
                a -= 2;
                Console.Write("*");
                Console.Write(new string('-', line));
                Console.Write(new string('@', a));
                Console.Write(new string('-', line));
                Console.WriteLine("*");
                line++;
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
