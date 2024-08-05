using System.Collections;

namespace Session2_Project
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Non Generic Collection HashTable [IDictionary - Key Value Pair]


			Hashtable ht = new Hashtable()
			{
				{"Ahmed",1},
				{"Ali",2},
				{"Mai",3}
			};

			ht.Add("Muhammad", 4);

			if (ht.Contains("Muhammad") == false)
			{
				ht.Add("Muhammad", 5);
			}
			/*ht.Add("Muhammad", 4);*/ //Unhandled exception. System.ArgumentException: Item has already been added.["Muhammad"]

			ht["amy"] = 6;
			//Console.WriteLine(ht[6]?.GetHashCode());

			foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"{entry.Key} , {entry.Value} , {entry.GetHashCode()}");
            }
            Console.WriteLine();





			#endregion
		}
	}
}
