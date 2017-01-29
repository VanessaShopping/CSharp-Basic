using System;

class FruitOrVegetable
{
    static void Main()
    {
        string fruitOrvegetable = Console.ReadLine();
        if (fruitOrvegetable == "banana" || fruitOrvegetable == "apple" || fruitOrvegetable == "kiwi" || fruitOrvegetable == "cherry" || fruitOrvegetable == "lemon" || fruitOrvegetable == "grapes")
        {
            Console.WriteLine("fruit");
        }
        else if (fruitOrvegetable == "tomato" || fruitOrvegetable == "cucumber" || fruitOrvegetable == "pepper" || fruitOrvegetable == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}