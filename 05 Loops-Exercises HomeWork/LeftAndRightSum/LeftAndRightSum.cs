using System;

class LeftAndRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;

        for (int i = 1; i <= 1; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                int leftNum = int.Parse(Console.ReadLine());
                leftSum = leftSum + leftNum;
            }
            for (int j = 1; j <= n; j++)
            {
                int rightNum = int.Parse(Console.ReadLine());
                rightSum = rightSum + rightNum;
            }

            int result = Math.Abs(leftSum - rightSum);
            if (result == 0)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else if (result != 0)
            {
                Console.WriteLine("No, diff = {0}", result);
            }
        }
    }
}