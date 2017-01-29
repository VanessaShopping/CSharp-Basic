﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            int pos = 0;
            while (pos < nums.Count - 1)
            {
                if (nums[pos] == nums[pos + 1])
                {
                    nums[pos] = nums[pos] + nums[pos + 1];
                    nums.RemoveAt(pos + 1);
                    pos--;
                    if (pos < 0) pos = 0;
                }
                else
                    pos++;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
