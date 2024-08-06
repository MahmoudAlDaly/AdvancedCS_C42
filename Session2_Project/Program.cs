using System.Collections;

namespace Session2_Project
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Non Generic Collection HashTable [IDictionary - Key Value Pair]


			//Hashtable ht = new Hashtable()
			//{
			//	{"Ahmed",1},
			//	{"Ali",2},
			//	{"Mai",3}
			//};

			//ht.Add("Muhammad", 4);

			//if (ht.Contains("Muhammad") == false)
			//{
			//	ht.Add("Muhammad", 5);
			//}
			///*ht.Add("Muhammad", 4);*/ //Unhandled exception. System.ArgumentException: Item has already been added.["Muhammad"]

			//ht["amy"] = 6;
			////Console.WriteLine(ht[6]?.GetHashCode());

			//foreach (DictionaryEntry entry in ht)
			//         {
			//             Console.WriteLine($"{entry.Key} , {entry.Value} , {entry.GetHashCode()}");
			//         }
			//         Console.WriteLine();





			#endregion

			#region Generic Collection Dictionary [IDictionary - Key Value Pair]

			//ArrayList arrayList = new ArrayList()
			//{
			//	1, 2, 3, 4,true,false,"Ali"
			//};

			//foreach (int i in arrayList)
			//{
			//	Console.WriteLine(i);
			//}

			Console.WriteLine();

			Dictionary<string,int> keyValues = new Dictionary<string, int>()
			{
				{"Ali",1 },
				{"Mai",2 },
				{"amy",3 },
			};

			keyValues.Add("Yuhia",4);

			if (!keyValues.ContainsKey("Ali"))
			{
				keyValues.Add("Ali", 1);   // An item with the same key has already been added. Key: Ali
			}

			keyValues.TryGetValue("emad",out int value);
			Console.WriteLine(value);
			

			foreach (KeyValuePair<string, int> items in keyValues)
			{
				Console.WriteLine($"{items.Key} :: {items.Value}");
			}

            Console.WriteLine();

            KeyValuePair<string, int>[] pair =
			{
				new KeyValuePair<string, int>("one",1),
				new KeyValuePair<string, int>("two",2),
				new KeyValuePair<string, int>("ten",10)
			};

			for (int i = 0; i < pair.Length; i++)
			{
				Console.WriteLine($"{pair[i].Key} : {pair[i].Value}");
			}

			#endregion
		}
	}
}
