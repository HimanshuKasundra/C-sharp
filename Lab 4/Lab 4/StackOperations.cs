using System;
using System.Collections.Generic;

namespace Lab4
{
    class StackOperations
    {
        public static void Run()
        {
            Stack<string> stack = new Stack<string>();

            // Push items
            stack.Push("Himanshu");
            stack.Push("Yash");
            stack.Push("Kishan");

            // Pop item
            string poppedItem = stack.Pop();
            Console.WriteLine($"Popped item: {poppedItem}");

            // Peek top item
            string topItem = stack.Peek();
            Console.WriteLine($"Top item: {topItem}");

            // Check if an item exists
            bool containsItem = stack.Contains("Himanshu");
            Console.WriteLine($"Contains Himanshu: {containsItem}");

            // Clear stack
            stack.Clear();

            Console.WriteLine("Stack operations completed.");
        }
    }
}