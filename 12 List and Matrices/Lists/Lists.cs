using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Lists
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Pesho");
            names.Add("Kiro");
            names.Add("Maria");
            names.Add("Ivan");
            names.Add("Kiro");

            //foreach (var item in names)
            //    Console.WriteLine(item);

            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            names.Insert(2, "Нов елемент"); // Новия елемент се записва на позиция 2 като измества всички след него с 1 позиция
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine("Insert(2, \"Нов елемент\") -> Добавяме нов елемент на позиция 2 \n");

            names.Remove("Kiro");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine("Remove(\"Kiro\") -> Премахваме  Kiro от списъка \n");

            names.RemoveAt(1);
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine("RemoveAt(1) премахваме елемент на позиция 1 \n");

            names[1] = "Смяна";
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine("names[1] = \"Смяна\" -> смяна на елемент по индекс [1] с друг елемент, както в масив\n");

            List<int> nums = new List<int>();
            nums.Add(5);
            nums.Add(7);
            nums.Add(13);
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine();

            List<int> anotherNums = new List<int>()
            {
                10, 20, 30, 40, 50
            };
            Console.WriteLine(string.Join(" ", anotherNums));

        }
    }
}
