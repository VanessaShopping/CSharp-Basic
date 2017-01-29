using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleBits
{
    class ShuffleBits
    {
        static void Main(string[] args)
        {
            uint first = uint.Parse(Console.ReadLine());
            uint second = uint.Parse(Console.ReadLine());

            ulong theNumber = 0;

            if (first >= second)
            {
                for (int i = 31; i >= 0; i--)
                {
                    theNumber = (theNumber << 1) | ((first >> i) & 1);
                    theNumber = (theNumber << 1) | ((second >> i) & 1);
                    Console.WriteLine(theNumber);
                }
            }
            else
            {
                for (int i = 31; i >= 0; i -= 2)
                {
                    theNumber = (theNumber << 1) | ((first >> i) & 1);
                    theNumber = (theNumber << 1) | ((first >> i - 1) & 1);
                    theNumber = (theNumber << 1) | ((second >> i) & 1);
                    theNumber = (theNumber << 1) | ((second >> i - 1) & 1);
                    Console.WriteLine(theNumber);

                }
            }

            Console.WriteLine(theNumber);
        }
    }
}
