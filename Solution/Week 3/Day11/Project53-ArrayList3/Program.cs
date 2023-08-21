using System;
using System.Collections;
namespace Csharp8Features
{
	public class ArrayListDemo
	{
		public static void Main()
		{
			ArrayList arrayList1 = new ArrayList();
			arrayList1.Add("Yousef");
			arrayList1.Add("Yousef");
			arrayList1.Add(10001); 
			arrayList1.Add("Makmudov");
			arrayList1.Add(" "); 
			arrayList1.Add(true); 
			arrayList1.Add(4.8M);
			arrayList1.Add(4.8);
			arrayList1.Add(4.8f);
			arrayList1.Add(null);

			foreach (var item in arrayList1)
			{
				Console.WriteLine(item);
			}
			
			string firstElement = (string)arrayList1[0]; //returns 101
			int secondElement = (int)arrayList1[2]; //returns
			Console.WriteLine("\n\n"+firstElement);
			Console.WriteLine(secondElement+"\n\n");
			
			var arrayList2 = new ArrayList()
			{
				102, "Smith", "Smith", true, 15.6
			};

			foreach (var item in arrayList2)
			{
				Console.WriteLine(item);
			}
		}
	}
}