using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidPasswordGenerator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            List<string> passwords = new List<string>();

            for (int a = 1; a <= n; a++)
            {
                for (int b = 1; b <= n; b++)
                {
                    for (int c = 'a'; c <= 'a' + l - 1; c++)
                    {
                        for (int d = 'a'; d <= 'a' + l - 1; d++)
                        {
                            if (a >= b)
                            {
                                for (int e = a + 1; e <= n; e++)
                                {
                                    passwords.Add("" + a + b + (char)c + (char)d + e);
                                }
                            }
                            else if (b >= a)
                            {
                                for (int e = b + 1; e <= n; e++)
                                {
                                    passwords.Add("" + a + b + (char)c + (char)d + e);
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", passwords));
        }
    }
}
