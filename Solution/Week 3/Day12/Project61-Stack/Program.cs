using System;
using System.Collections;

namespace StackCollectionDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack stack = new Stack();

			stack.Push(10);
			stack.Push("Hello");
			stack.Push(3.14f);
			stack.Push(true);
			stack.Push(67.8);
			stack.Push('A');


			Console.WriteLine("Original stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}


			Console.WriteLine("\nRemoving an item from the stack:");
			stack.Pop();
			Console.WriteLine("New stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("\nRemoving all items from the stack:");
			stack.Clear();
			Console.WriteLine("New stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}


			stack.Push("C#");
			stack.Push(42);
			stack.Push("World");


			Console.WriteLine("\nNew stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}


			Console.WriteLine("\nChecking if an item is in the stack:");
			bool containsCSharp = stack.Contains("C#");
			bool containsPython = stack.Contains("Python");
			Console.WriteLine("Contains C#: " + containsCSharp);
			Console.WriteLine("Contains Python: " + containsPython);


			Console.WriteLine("\nCloning the stack:");
			Stack clonedStack = (Stack)stack.Clone();
			Stack clonedStack2 = stack;
			Console.WriteLine("Original stack:");
			foreach (object item in stack)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("Cloned stack:");
			foreach (object item in clonedStack)
			{
				Console.WriteLine(item);
			}


			Console.WriteLine("\nCopying the stack to an array:");
			object[] stackArray = new object[stack.Count];
			stack.CopyTo(stackArray, 0);
			Console.WriteLine("Stack array:");
			foreach (object item in stackArray)
			{
				Console.WriteLine(item);
			}


			Console.WriteLine("\nPeeking at the top item in the stack:");
			object topItem = stack.Peek();
			Console.WriteLine("Top item: " + topItem);

			Console.ReadKey();
		}
	}
}