using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectGirlfriend
{
    class PerfectGirlfriend
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int sum = 0;
            int perfectGirls = 0;

            while (command != "Enough dates!")
            {
                sum = 0;
                string[] line = command.Split('\\');
                string day = line[0];
                string phone = line[1];
                string braSize = line[2];
                string name = line[3];

                // Days
                switch (day)
                {
                    case "Monday": sum += 1; break;
                    case "Tuesday": sum += 2; break;
                    case "Wednesday": sum += 3; break;
                    case "Thursday": sum += 4; break;
                    case "Friday": sum += 5; break;
                    case "Saturday": sum += 6; break;
                    case "Sunday": sum += 7; break;
                }

                // Phone

                for (int i = 0; i < phone.Length; i++)
                    sum += int.Parse(phone[i].ToString());

                // Bra

                if (braSize.Length == 3)
                    sum += int.Parse(braSize.Substring(0, 2)) * (int)braSize[braSize.Length - 1];
                else
                    sum += int.Parse(braSize.Substring(0, 3)) * (int)braSize[braSize.Length - 1];

                
                // Name
                sum -= (int)name[0] * name.Length;

                if (sum >= 6000)
                {
                    Console.WriteLine("{0} is perfect for you.", name);
                    perfectGirls++;
                }
                else
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", name);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(perfectGirls);
        }
    }
}
