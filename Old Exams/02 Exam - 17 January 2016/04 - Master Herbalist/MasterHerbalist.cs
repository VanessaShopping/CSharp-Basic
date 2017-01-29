using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterHerbalist
{
    class MasterHerbalist
    {
        static void Main(string[] args)
        {
            int neededAverageMoney = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int totalMoney = 0;
            int days = 0;

            while (command != "Season Over")
            {
                days++;
                string[] condition = command.Split();
                int hours = int.Parse(condition[0]);
                string letters = condition[1];
                int price = int.Parse(condition[2]);
                int herbs = 0;
                for (int i = 0; i < hours; i++)
                {
                    if (letters[i%letters.Length] == 'H')
                        herbs++;

                }
                totalMoney = totalMoney + (herbs * price);

                command = Console.ReadLine();
            }
            decimal averageMoney = (decimal)totalMoney / days;
            if (averageMoney >= neededAverageMoney)
                Console.WriteLine("Times are good. Extra money per day: {0:F2}.", averageMoney - neededAverageMoney);

            else
            {
                int moneyNeeded = (neededAverageMoney * days) - totalMoney;
                Console.WriteLine("We are in the red. Money needed: {0}.", moneyNeeded);
            }
        }
    }
}
