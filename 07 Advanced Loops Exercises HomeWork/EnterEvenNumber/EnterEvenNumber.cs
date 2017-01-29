using System;

class EnterEvenNumber
{
    static void Main()
    {
        int n = 0;

        while (true)
        {
            try
            {
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine("{0}", n);
                    break;
                }
                Console.WriteLine("Invalid number");
            }
            catch
            {
                Console.WriteLine("Това не е число");
            }
           
        }
    }
}