using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            //List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //for (int i = 0; i < nums.Count; i++)
            //    if (nums[i] < 0)
            //    {
            //        nums.RemoveAt(i);
            //        i--;
            //    }
            //nums.Reverse();

            //if (nums.Count == 0)
            //    Console.WriteLine("empty");

            //else
            //    Console.WriteLine(string.Join(" ", nums));

            // Second problem solution

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positives = new List<int>();

            foreach (var num in nums)
            {
                if (num >= 0)
                {
                    positives.Add(num);
                }
            }

            positives.Reverse();
            if (positives.Count == 0)
                Console.WriteLine("empty");
            else
                Console.WriteLine(string.Join(" ", positives));

        }
    }
}
