using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertListToArrayToList
{
    class ConvertListToArrayToList
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]
            {
                100, 200 ,300
            };
            Console.WriteLine(string.Join(" ", arr));

            List<int> nums = new List<int>(arr); // в скобите () добавяме масива arr и така списъка взема стойностите от масива. 
            Console.WriteLine(string.Join(" ", nums));

            // Другият начин да добавим масив в списък е чрез nums.AddRange(arr);
        }
    }
}
