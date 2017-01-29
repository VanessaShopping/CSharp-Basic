using System;

class EvenPowersOf2
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        if (n % 2 != 0)
        {
            n = n - 2;
        }
        for (int i = 0; i <= n + 1; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}