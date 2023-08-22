using System;
using System.Collections;

namespace QueueCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new Queue collection
            Queue queue = new Queue(); 

            // Adding items to the queue using the Enqueue method
            queue.Enqueue(10);
            queue.Enqueue(3.14);
            queue.Enqueue(true);
            queue.Enqueue('A');
            queue.Enqueue("Hello");

            Console.WriteLine("Items in the queue:");
            // Printing the queue items using foreach loop
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            // Removing an item from the queue using the Dequeue method
            var removedItem = queue.Dequeue();
            Console.WriteLine($"\nRemoved item: {removedItem}");

            // Viewing the next item in the queue using the Peek method
            var nextItem = queue.Peek();
            Console.WriteLine($"\nNext item in the queue: {nextItem}");

            // Checking if an item is in the queue using the Contains method
            var isInQueue = queue.Contains(true);
            Console.WriteLine($"\nIs true in the queue? {isInQueue}");

            // Creating a shallow copy of the queue using the Clone method
            var clonedQueue = (Queue)queue.Clone();

            // Copying the items in the queue to an array using the CopyTo method
            object[] queueArray = new object[queue.Count];
            queue.CopyTo(queueArray, 0);

            // Printing the items in the cloned queue and the array
            Console.WriteLine("\nItems in the cloned queue:");
            foreach (var item in clonedQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nItems in the queue array:");
            foreach (var item in queueArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}