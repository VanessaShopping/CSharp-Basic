using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerStock
{
    class BeerStock
    {
        static void Main(string[] args)
        {
            long beersCout = 0;
            long cases = 0;
            long packs = 0;

            long neededBeers = long.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            while (line != "Exam Over")
            {
                string[] parameters = line.Split();
                long amount = long.Parse(parameters[0]);

                string type = parameters[1];
                switch (type)
                {
                    case "cases":
                        beersCout += amount * 24;
                        break;
                    case "sixpacks":
                        beersCout += amount * 6;
                        break;
                    default:
                        beersCout += amount;
                        break;
                }

                line = Console.ReadLine();
            }

            beersCout = beersCout - (beersCout / 100);

            if (beersCout >= neededBeers)
            {
                long leftBeers = beersCout - neededBeers;

                cases = leftBeers / 24;
                leftBeers %= 24;
                packs = leftBeers / 6;
                leftBeers %= 6;

                Console.WriteLine(
                    $"Cheers! Beer left: {cases} cases, {packs} sixpacks and {leftBeers} beers.");
            }
            else
            {
                long leftBeers = neededBeers - beersCout;

                cases = leftBeers / 24;
                leftBeers %= 24;
                packs = leftBeers / 6;
                leftBeers %= 6;

                Console.WriteLine(
                    $"Not enough beer. Beer needed: {cases} cases, {packs} sixpacks and {leftBeers} beers.");
            }


            //long neededBeers = long.Parse(Console.ReadLine());
            //string line = Console.ReadLine();
            //long beersCout = 0;


            //long enoughtCases = 0;
            //long enoughtSixPacks = 0;
            //long enoughtBeers = 0;

            //long notEnoughtCases = 0;
            //long notEnoughtSixPacks = 0;
            //long notEnoughtBeers = 0;
            //while (line != "Exam Over")
            //{
            //    string[] parameters = line.Split();
            //    long amount = long.Parse(parameters[0]);
            //    string type = parameters[1];
            //    switch (type)
            //    {
            //        case "cases":
            //            beersCout += amount * 24;
            //            break;
            //        case "sixpacks":
            //            beersCout += amount * 6;
            //            break;
            //        default:
            //            beersCout += amount;
            //            break;
            //    }
            //    line = Console.ReadLine();
            //}
            
            //    beersCout = beersCout - (beersCout / 100);

            //if (beersCout >= neededBeers)
            //{
            //    long leftBeers = beersCout - neededBeers;
            //    if (leftBeers >= 24)
            //    {
            //        enoughtCases = leftBeers / 24;
            //        leftBeers = leftBeers - (enoughtCases * 24);
            //    }
            //    if (leftBeers >= 6)
            //    {
            //        enoughtSixPacks = leftBeers / 6;
            //        leftBeers = leftBeers - (enoughtSixPacks * 6);
            //    }
            //    if (leftBeers >= 1)
            //    {
            //        enoughtBeers = leftBeers;
            //    }
            //    Console.WriteLine($"Cheers! Beer left: {enoughtCases} cases, {enoughtSixPacks} sixpacks and {enoughtBeers} beers.");
            //}

            //else
            //{
            //    long leftBeers = neededBeers - beersCout;
            //    if (leftBeers >= 24)
            //    {
            //        notEnoughtCases = leftBeers / 24;
            //        leftBeers = leftBeers - (notEnoughtCases * 24);
            //    }
            //    if (leftBeers >= 6)
            //    {
            //        notEnoughtSixPacks = leftBeers / 6;
            //        leftBeers = leftBeers - (notEnoughtSixPacks * 6);
            //    }
            //    if (leftBeers >= 1)
            //    {
            //        notEnoughtBeers = leftBeers;
            //    }
            //    Console.WriteLine($"Not enough beer. Beer needed: {notEnoughtCases} cases, {notEnoughtSixPacks} sixpacks and {notEnoughtBeers} beers.");
            //}
        }
    }
}
