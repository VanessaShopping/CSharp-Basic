using System;
using System.Collections.Generic;

class CurrencyConverterTwo
{
    static void Main()
    {
        decimal moneyToConvert = decimal.Parse(Console.ReadLine());

        string firstCurrency = Console.ReadLine();
        string secondCurrency = Console.ReadLine();

        var currencies = new Dictionary<string, decimal>();

        decimal result = moneyToConvert * (currencies[firstCurrency] / currencies[secondCurrency]);
        Console.WriteLine("{0} {1}", Math.Round(result, 2), secondCurrency);
    }
}