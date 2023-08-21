using System.Collections;
namespace HasntableExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Hashtable hashtable = new Hashtable();
			//Key-Value pair
			hashtable.Add("ID", 1001);
			hashtable.Add("School", "SD1");
			hashtable.Add("Address", 494949);
			hashtable.Add("City", "SALATIGA");
			hashtable.Add("Email", "yes@yo.com");
			hashtable.Add(123,123);

			foreach(var element in hashtable) {
				Console.WriteLine(element);
			}
			
			foreach (object obj in hashtable.Keys)
			{
				Console.WriteLine(obj + " : " + hashtable[obj]);
			}

			foreach (DictionaryEntry de in hashtable) 
			{
				Console.WriteLine($"Key: {de.Key}, Value: {de.Value}");
			}
			
			Console.WriteLine("ID : " + hashtable["ID"]);
			Console.WriteLine("School : " + hashtable["School"]);
			Console.WriteLine("Address : " + hashtable["Address"]);
			Console.WriteLine("Email ID : " + hashtable["City"]);
			Console.WriteLine("123 : " + hashtable[123]);
			
			Hashtable hashTable2 = new Hashtable() 
			{
				{"ID", 1001},
				{"School", "SD1"},
				{"Address", 494949},
				{"City", "SALATIGA"},
				{"Email", "YES@YO.COM"}
			};
			
			Console.WriteLine("City Contains : " + hashTable2.Contains("City"));
			Console.WriteLine("City Contains : " + hashTable2.Contains("SALATIGA"));
			Console.WriteLine("City Contains Key : " + hashTable2.ContainsKey("City")); 
			Console.WriteLine("City Contains Value : " + hashTable2.ContainsValue("SALATIGA"));
			
			hashTable2.Add("ID", 1002); //will error because already added
		 	hashTable2.Remove("City");
			hashTable2["ID"] = 1003;
		}
	}
} 