using System;

class CurrencyConverter
{
    static void Main()
    {
        decimal sum = decimal.Parse(Console.ReadLine());
        string inputCurrency = Console.ReadLine().ToLower();
        string outputCurrency = Console.ReadLine().ToLower();
        decimal result = 0.0m;

        if (inputCurrency == "bgn")
        {
            if (outputCurrency == "bgn")
            {
                result = sum / 1;
            }
            else if (outputCurrency == "usd")
            {
                result = sum / 1.79549m;
            }
            else if (outputCurrency == "eur")
            {
                result = sum / 1.95583m;
            }
            else if (outputCurrency == "gbp")
            {
                result = sum / 2.53405m;
            }
        }
        else if (inputCurrency == "usd")
        {
            sum = sum * 1.79549m;
            if (outputCurrency == "bgn")
            {
                result = sum / 1;
            }
            else if (outputCurrency == "usd")
            {
                result = sum / 1.79549m;
            }
            else if (outputCurrency == "eur")
            {
                result = sum / 1.95583m;
            }
            else if (outputCurrency == "gbp")
            {
                result = sum / 2.53405m;
            }
        }
        else if (inputCurrency == "eur")
        {
            sum = sum * 1.95583m;
            if (outputCurrency == "bgn")
            {
                result = sum / 1;
            }
            else if (outputCurrency == "usd")
            {
                result = sum / 1.79549m;
            }
            else if (outputCurrency == "eur")
            {
                result = sum / 1.95583m;
            }
            else if (outputCurrency == "gbp")
            {
                result = sum / 2.53405m;
            }
        }
        else if (inputCurrency == "gbp")
        {
            sum = sum * 2.53405m;
            if (outputCurrency == "bgn")
            {
                result = sum / 1;
            }
            else if (outputCurrency == "usd")
            {
                result = sum / 1.79549m;
            }
            else if (outputCurrency == "eur")
            {
                result = sum / 1.95583m;
            }
            else if (outputCurrency == "gbp")
            {
                result = sum / 2.53405m;
            }
        }
        Console.WriteLine(Math.Round(result, 2));
    }
}