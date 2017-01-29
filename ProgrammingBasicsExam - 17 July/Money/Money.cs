using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            double bitcoin = double.Parse(Console.ReadLine());
            double china = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double bitcoinValue = bitcoin * 1168;
            double chinaValue = (china * 0.15) * 1.76;
            double dolarValue = 1.76;
            double euroValue = 1.95;

            double result = ((bitcoinValue + chinaValue) / euroValue) - ((bitcoinValue + chinaValue) / euroValue) * (comission / 100);

            Console.WriteLine(result);

        }
    }
}
