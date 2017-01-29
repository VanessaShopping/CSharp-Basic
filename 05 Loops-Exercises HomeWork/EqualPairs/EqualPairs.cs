using System;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int currentSum = 0;
        int previousSum = 0;
        int maxDiff = 0;
        int currentDiff = 0;


        for (int i = 1; i <= n; i++)
        {
            previousSum = currentSum;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            currentSum = a + b;
            currentDiff = Math.Abs(currentSum - previousSum);
            if (currentDiff > maxDiff && i > 1)
            {
                maxDiff = currentDiff;
            }
        }
        if (maxDiff == 0)
        {
            Console.WriteLine("Yes value " + currentSum);
        }
        else
        {
            Console.WriteLine("no maxdiff " + maxDiff);
        }
    }

}