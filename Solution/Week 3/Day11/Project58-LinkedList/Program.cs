using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
 
        LinkedList<string> myLinkedList = new LinkedList<string>();


        myLinkedList.AddLast("Apple");
        myLinkedList.AddLast("Banana");
        myLinkedList.AddLast("Cherry");

        
        myLinkedList.AddFirst("Apricot");

        LinkedListNode<string> node = myLinkedList.Find("Banana");
        myLinkedList.AddBefore(node, "Avocado");


        myLinkedList.AddLast("Date");

        foreach (string element in myLinkedList)
        {
            Console.WriteLine(element);
        }

        myLinkedList.RemoveFirst();
        myLinkedList.RemoveLast();
        myLinkedList.Remove("Cherry");

        Console.WriteLine("\nLinked List After Removals:");
        foreach (string element in myLinkedList)
        {
            Console.WriteLine(element);
        }

        myLinkedList.Clear();
    }
}