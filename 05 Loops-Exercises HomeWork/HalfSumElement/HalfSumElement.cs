using System;

class HalfSumElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int maxNumber = int.MinValue;
        int result = 0;
        for (int i = 1; i <= n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > maxNumber)
            {
                maxNumber = num;
            }
            result = result + num;
        }
        if (result == 2 * maxNumber)
        {
            Console.WriteLine("Yes sum " + maxNumber);
        }
        else
        {
            Console.WriteLine("No diff {0}", Math.Abs((2 * maxNumber) - result));
        }
    }
}