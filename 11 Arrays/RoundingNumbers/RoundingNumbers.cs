using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class RoundingNumbers
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                // Първо решение
                //int rounded;
                //if(nums[i] > 0)
                //rounded = (int)(nums[i] + 0.5);
                //else
                //    rounded = (int)(nums[i] - 0.5);

                // Второ решение
                //int rounded = (nums[i] > 0) ? (int)(nums[i] + 0.5) : (int)(nums[i] - 0.5);

                // Трето решение
                int rounded = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                
                Console.WriteLine("{0} => {1}", nums[i], rounded); 
            }
        }
    }
}
