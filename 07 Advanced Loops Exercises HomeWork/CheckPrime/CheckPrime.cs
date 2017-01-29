using System;

class CheckPrime
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        bool prime = n > 1;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                prime = false;
                break;
            }
        }
        if (prime == true)
        {
            Console.WriteLine("prime");
        }
        else
        {
            Console.WriteLine("not prime");
        }
    }
}