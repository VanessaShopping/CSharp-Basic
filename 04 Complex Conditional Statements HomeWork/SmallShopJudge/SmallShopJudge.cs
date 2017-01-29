using System;

class SmallShopJudge
{
    static void Main()
    {
        string product = Console.ReadLine().ToLower();
        string city = Console.ReadLine().ToLower();
        double quantity = double.Parse(Console.ReadLine());
        double result = 0.0;

        if (city == "sofia")
        {
            if (product == "coffee")
            {
                result = quantity * 0.5;
            }
            else if (product == "water")
            {
                result = quantity * 0.8;
            }
            else if (product == "beer")
            {
                result = quantity * 1.2;
            }
            else if (product == "sweets")
            {
                result = quantity * 1.45;
            }
            else if (product == "peanuts")
            {
                result = quantity * 1.6;
            }
        }
        if (city == "plovdiv")
        {
            if (product == "coffee")
            {
                result = quantity * 0.4;
            }
            else if (product == "water")
            {
                result = quantity * 0.7;
            }
            else if (product == "beer")
            {
                result = quantity * 1.15;
            }
            else if (product == "sweets")
            {
                result = quantity * 1.3;
            }
            else if (product == "peanuts")
            {
                result = quantity * 1.5;
            }
        }
        if (city == "varna")
        {
            if (product == "coffee")
            {
                result = quantity * 0.45;
            }
            else if (product == "water")
            {
                result = quantity * 0.7;
            }
            else if (product == "beer")
            {
                result = quantity * 1.1;
            }
            else if (product == "sweets")
            {
                result = quantity * 1.35;
            }
            else if (product == "peanuts")
            {
                result = quantity * 1.55;
            }
        }
        Console.WriteLine(result);
    }
}