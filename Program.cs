// C# program to remove duplicates
// from a sorted descending order list
using System;

namespace ListReader
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<int> numbers = new List<int> { 8, 13, 13, 15, 29, 3, 3, 4, 55, 55, 6 };
            IEnumerable<int> distinctNumbers = numbers.Distinct().OrderDescending().ToList();
            Console.WriteLine("Original list:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("\nList with duplicates removed and arranged in descending order:");
            foreach (int number in distinctNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}

