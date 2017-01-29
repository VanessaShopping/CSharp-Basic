using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0; i < nums.Length; i++)
                nums[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < nums.Length / 2; i++)
            {
                var old = nums[i];
                nums[i] = nums[nums.Length - i - 1];
                nums[nums.Length - i - 1] = old;
            }

            foreach (var item in nums)
                Console.WriteLine(item);


        }
    }
}
