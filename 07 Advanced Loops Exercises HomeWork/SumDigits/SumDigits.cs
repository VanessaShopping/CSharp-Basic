using System;

class SumDigits
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int result = 0;
        do
        {
            result = result + num % 10;
            num = num / 10;
        } while (num != 0);
        Console.WriteLine(result);
    }
}