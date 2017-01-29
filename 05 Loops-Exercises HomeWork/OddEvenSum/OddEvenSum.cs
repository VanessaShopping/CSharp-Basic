using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sumA = 0;
        int sumB = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                int odd = int.Parse(Console.ReadLine());
                sumA = sumA + odd;
            }
            else if (i % 2 == 0)
            {
                int even = int.Parse(Console.ReadLine());
                sumB = sumB + even;
            }
        }
        int result = Math.Abs(sumA - sumB);
        if (result == 0)
        {
            Console.WriteLine("Yes, sum = {0}", sumA);
        }
        else if (result != 0)
        {
            Console.WriteLine("No, diff = {0}", result);
        }
    }
}