using System;
using System.Collections.Generic;
using System.IO;

namespace DataStructuresDemo
{
    class Program
    {
        static void Main(string[] args)
        {
                //this would change depending on the machine the user is on 
            string filePath = @"C:\Users\tyron\Downloads\DORASMAP\data.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Data file not found. AAAHHHHHHHHHHHHHHHHHHHHHH PAINNNNNNNNNNNN");
                return;
            }

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Array 
            string[] array = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                array[i] = lines[i];
            }

            Console.WriteLine("Array contents:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nArray explanation:");
            Console.WriteLine("An array stores elements in a fixed size, indexed structure. Access by index is O(1), but insertion or deletion in the middle requires shifting elements, which is O(n).");

            // Dictionary (Map) 
            Dictionary<int, string> map = new Dictionary<int, string>();
            for (int i = 0; i < lines.Length; i++)
            {
                map[i] = lines[i]; // using index as key
            }

            Console.WriteLine("\nDictionary (Map) contents:");
            foreach (var kvp in map)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            Console.WriteLine("\nDictionary explanation:");
            Console.WriteLine("A dictionary stores key value pairs. Access by key is O(1) on average. Dictionaries are better than arrays when you need fast lookups by arbitrary keys.");

            //  Stack
            Stack<string> stack = new Stack<string>();
            foreach (var line in lines)
            {
                stack.Push(line); // add to the top
            }

            Console.WriteLine("\nStack operations (LIFO - Last In First Out):");
            while (stack.Count > 0)
            {
                Console.WriteLine($"Popped: {stack.Pop()}");
            }

            Console.WriteLine("\nStack explanation:");
            Console.WriteLine("A stack follows Last In First Out (LIFO). The last element added is the first one removed. Good for undo operations, parsing expressions, or function call management.");

            //  Queue 
            Queue<string> queue = new Queue<string>();
            foreach (var line in lines)
            {
                queue.Enqueue(line); // add to the end
            }

            Console.WriteLine("\nQueue operations (FIFO - First In First Out):");
            while (queue.Count > 0)
            {
                Console.WriteLine($"Dequeued: {queue.Dequeue()}");
            }

            Console.WriteLine("\nQueue explanation:");
            Console.WriteLine("A queue follows First In First Out (FIFO). The first element added is the first removed. Ideal for task scheduling, printing jobs, or customer service lines.");

            // --- Comparisons ---
            Console.WriteLine("\n Comparisons ");
            Console.WriteLine("Array vs. Dictionary:");
            Console.WriteLine("- Arrays are efficient for sequential access and fixed-size storage.");
            Console.WriteLine("- Dictionaries are efficient for random access via keys and dynamic resizing.");
            Console.WriteLine("\nStack vs. Queue:");
            Console.WriteLine("- Stacks are best for LIFO operations.");
            Console.WriteLine("- Queues are best for FIFO operations.");
        }
    }
}

