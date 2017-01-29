using System;

class OddEvenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double evenSum = 0;
        double evenMax = double.MinValue;
        double evenMin = double.MaxValue;
        double oddSum = 0;
        double oddMax = double.MinValue;
        double oddMin = double.MaxValue;

        for (int i = 0; i <= n - 1; i++)
        {
            if (i % 2 != 0)
            {
                double evenNum = double.Parse(Console.ReadLine());
                evenSum = evenSum + evenNum;
                if (evenNum > evenMax)
                {
                    evenMax = evenNum;
                }
                if (evenNum < evenMin)
                {
                    evenMin = evenNum;
                }
            }
            else if (i % 2 == 0)
            {
                double oddNum = double.Parse(Console.ReadLine());
                oddSum = oddSum + oddNum;
                if (oddNum > oddMax)
                {
                    oddMax = oddNum;
                }
                if (oddNum < oddMin)
                {
                    oddMin = oddNum;
                }
            }
        }

        if (oddSum == 0)
        {
            Console.WriteLine("OddSum = {0}", oddSum);
            Console.WriteLine("OddMin = no");
            Console.WriteLine("OddMax = no");
        }
        else
        {
            Console.WriteLine("OddSum = {0}", oddSum);
            Console.WriteLine("OddMin = {0}", oddMin);
            Console.WriteLine("OddMax = {0}", oddMax);
        }
        if (evenSum == 0)
        {
            Console.WriteLine("EvenSum = {0}", evenSum);
            Console.WriteLine("EvenMin = no");
            Console.WriteLine("EvenMax = no");
        }
        else
        {
            Console.WriteLine("EvenSum = {0}", evenSum);
            Console.WriteLine("EvenMin = {0}", evenMin);
            Console.WriteLine("EvenMax = {0}", evenMax);
        }


    }
}