﻿using System;

class USDtoBGN
{
    static void Main()
    {
        decimal usd = decimal.Parse(Console.ReadLine());
        decimal bgn = usd * 1.79549m;
        Console.WriteLine(Math.Round(bgn, 2));
    }
}