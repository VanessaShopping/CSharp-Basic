using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lenght = 0;
            int maxLenght = 0;
            int prev = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > prev)
                    lenght++;
                else
                    lenght = 1;
                if (lenght > maxLenght)
                    maxLenght = lenght;
                prev = num;
            }
            Console.WriteLine(maxLenght);
        }
    }
}
