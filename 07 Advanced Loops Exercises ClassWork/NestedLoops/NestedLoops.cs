using System;


class NestedLoops
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 2;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(num);
            num = num * 2;
        }
    }
}