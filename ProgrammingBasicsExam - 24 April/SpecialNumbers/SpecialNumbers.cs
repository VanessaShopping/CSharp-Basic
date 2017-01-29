using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> specialNumbers = new List<string>();

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (n % a == 0 && n % b == 0 && n % c == 0 && n % d == 0)
                            {
                                specialNumbers.Add(""+a+b+c+d);
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ",specialNumbers));
        }
    }
}
