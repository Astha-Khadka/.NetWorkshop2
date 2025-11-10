using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop2
{
    internal class Collection
    {
        public void display()
        {
            Console.WriteLine("\n--- Working with List<string> ---");
            List<string> favoriteFruits = new List<string> { "Apple", "Banana", "Orange" };

            Console.WriteLine("Original fruits list:");
            PrintFruitsList(favoriteFruits);

            favoriteFruits.Add("Mango");
            Console.WriteLine("\nAfter adding Mango:");
            PrintFruitsList(favoriteFruits);

            favoriteFruits.Remove("Banana");
            Console.WriteLine("\nAfter removing Banana:");
            PrintFruitsList(favoriteFruits);

            Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Apple" },
            { 2, "Banana" },
            { 3, "Orange" }
        };

            Console.WriteLine("Original dictionary:");
            PrintFruitDictionary(fruitDictionary);

            fruitDictionary.Add(4, "Mango");
            Console.WriteLine("\nAfter adding Mango with ID 4:");
            PrintFruitDictionary(fruitDictionary);

            Console.WriteLine($"\nFruit with ID 2: {fruitDictionary[2]}");
        }

        static void PrintFruitsList(List<string> fruits)
        {
            foreach (string fruit in fruits)
            {
                Console.WriteLine($"- {fruit}");
            }
        }
        static void PrintFruitDictionary(Dictionary<int, string> fruitDict)
        {
            foreach (KeyValuePair<int, string> entry in fruitDict)
            {
                Console.WriteLine($"ID: {entry.Key}, Fruit: {entry.Value}");
            }
        }
    }
}
