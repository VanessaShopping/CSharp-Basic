using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score: ");
        double score = double.Parse(Console.ReadLine());
        double bonus = 0.0;
        if (score <= 100)
        {
            bonus = 5;
        }
        else if (score <= 1000)
        {
            bonus = score * 0.2;
        }
        else if (score > 1000)
        {
            bonus = score * 0.1;
        }
        if (score % 2 == 0)
        {
            bonus = bonus + 1;
        }
        else if (score % 10 == 5)
        {
            bonus = bonus + 2;
        }
        Console.WriteLine("Bonus score: {0}", bonus);
        Console.WriteLine("Total score: {0}", score + bonus);
    }
}