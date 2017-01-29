using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmergencyRepairs
{
    class EmergencyRepairs
    {
        static void Main(string[] args)
        {
            ulong wall = ulong.Parse(Console.ReadLine());
            int kit = int.Parse(Console.ReadLine());
            int attack = int.Parse(Console.ReadLine());


            for (int i = 0; i < attack; i++)
            {
                byte n = byte.Parse(Console.ReadLine());
                wall = wall & ~((ulong)1 << n);
            }
            for (int i = 0; i < 64; i++)
            {
                ulong zero = (wall >> i) & 1;
                if (zero == 0 && kit > 0)
                {
                    bool hole = false;
                    while (kit > 0 && i + 1 < 64 && ((wall >> (i + 1) & 1) == 0))
                    {
                        wall = wall | ((ulong)1 << i);
                        i++;
                        kit--;
                        hole = true;
                    }
                    if (hole && kit > 0)
                    {
                        wall = wall | ((ulong)1 << i);
                        kit--;
                    }
                }
            }
            Console.WriteLine(wall);
        }
    }
}
