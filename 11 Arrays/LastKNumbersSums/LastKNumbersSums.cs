using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSums
{
    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger[] nums = new BigInteger[n];
            nums[0] = 1;

            for (int i = 1; i < n; i++)
            {
                // array[i] = Сумата от предните К числа

                BigInteger sum = 0;
                for (int prev = i - k; prev <= i - 1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += nums[prev];
                        nums[i] = sum;
                    }
                }
            }
            for (int cw = 0; cw < n; cw++)
                Console.WriteLine(nums[cw]);
        }
    }
}
