using System;

class PowersOfTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;

        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(num);
            num = num * 2;
        }


        // Another Loop
        //for (num = 1; num <= Math.Pow(2, n); num *= 2)
        //{
        //    Console.WriteLine(num);
        //}
    }
}