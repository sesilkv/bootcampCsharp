using System;
using System.Collections;

namespace ArrayListDemo
{
	class Program
	{
		static void Main(string[] args)
		{

			ArrayList list = new ArrayList();
			list.Add(10);
			list.Add("Hello");
			list.Add(3.14f);


			ArrayList clonedList1 = list;
			Console.WriteLine("Original list:");
			foreach (object item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("Reference list 1:");
			foreach (object item in clonedList1)
			{
				Console.WriteLine(item);
			}

			list.Add("New item");
			Console.WriteLine("\nOriginal list after adding a new item:");
			foreach (object item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("Referenced list 1 after adding a new item:");
			foreach (object item in clonedList1)
			{
				Console.WriteLine(item);
			}

			// Creating a shallow copy
			ArrayList clonedList2 = (ArrayList)list.Clone();
			Console.WriteLine("\nOriginal list:");
			foreach (object item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("Cloned list 2:");
			foreach (object item in clonedList2)
			{
				Console.WriteLine(item);
			}
			
			list.Add("Another new item");
			Console.WriteLine("\nOriginal list after adding another new item:");
			foreach (object item in list)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("Cloned list 2 after adding another new item:");
			foreach (object item in clonedList2)
			{
				Console.WriteLine(item);
			}

			Console.ReadKey();
		}
	}
}