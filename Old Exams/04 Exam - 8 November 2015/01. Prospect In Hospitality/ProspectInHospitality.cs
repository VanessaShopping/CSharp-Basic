using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProspectInHospitality
{
    class ProspectInHospitality
    {
        static void Main(string[] args)
        {
            decimal builders = decimal.Parse(Console.ReadLine()) * 1500.04m;
            decimal receptionists = decimal.Parse(Console.ReadLine()) * 2102.10m;
            decimal chambermaids = decimal.Parse(Console.ReadLine()) * 1465.46m;
            decimal technicians = decimal.Parse(Console.ReadLine()) * 2053.33m;
            decimal otherStaff = decimal.Parse(Console.ReadLine()) * 3010.98m;

            decimal nikiSalaryUSD = decimal.Parse(Console.ReadLine());
            decimal usaCurrency = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal nikiSalaryBGN = nikiSalaryUSD * usaCurrency;
            decimal amount = builders + receptionists + chambermaids + technicians + otherStaff + nikiSalaryBGN + mySalary;
            Console.WriteLine($"The amount is: {amount:F2} lv.");

            if (amount <= budget)
            {
                decimal moneyLeft = budget - amount;
                Console.WriteLine($@"YES \ Left: {moneyLeft:F2} lv.");
            }
            else
            {
                decimal neededMoney = amount - budget;
                Console.WriteLine($@"NO \ Need more: {neededMoney:F2} lv.");
            }
        }
    }
}
