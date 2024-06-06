using System;
using System.Collections.Generic;

namespace Lab4
{
    class QueueOperations
    {
        public static void Run()
        {
            Queue<int> queue = new Queue<int>();

            // Enqueue items
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Dequeue item
            int dequeuedItem = queue.Dequeue();
            Console.WriteLine($"Dequeued item: {dequeuedItem}");

            // Peek front item
            int frontItem = queue.Peek();
            Console.WriteLine($"Front item: {frontItem}");

            // Check if an item exists
            bool containsQueueItem = queue.Contains(20);
            Console.WriteLine($"Contains 20: {containsQueueItem}");

            // Clear queue
            queue.Clear();

            Console.WriteLine("Queue operations completed.");
        }
    }
}