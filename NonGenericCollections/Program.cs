using System.Collections;

namespace NonGenericCollections
{
	internal class Program
	{
		public static int SumArray(ArrayList numbers)
		{
			int sum = 0;
			
			if (numbers != null)
			{
				for (int i = 0; i < numbers.Count; i++)
				{
					sum += (int?) numbers[i] ?? 0;    // casting form object(ref type) to int(value type)  unboxing
				}
			}

			return sum;
		}
		static void Main(string[] args)
		{

			#region Part 08 Non Generic Collections [List]


			ArrayList arrayList = new ArrayList();
            Console.WriteLine($"count = {arrayList.Count} , cap = {arrayList.Capacity}");

			arrayList.Add(1); // count = 0  cap = 0
			arrayList.Add(1);
			arrayList.Add(1);
			arrayList.Add(1);
			arrayList.Add(1); // count = 5  cap = 8

			arrayList.AddRange(new int[] { 6, 7, 8,9 });  // count = 9  cap = 16

			Console.WriteLine($"count = {arrayList.Count} , cap = {arrayList.Capacity}");

			arrayList.TrimToSize(); // delete unused bytes
			Console.WriteLine("after TrimToSize");
			Console.WriteLine($"count = {arrayList.Count} , cap = {arrayList.Capacity}");

			ArrayList arrayList2 = new ArrayList() { 1,2,3,4,5,6,7,8,100 };
			foreach(int num in arrayList2)
			{
				Console.WriteLine(num);
			}

            Console.WriteLine(	);


            arrayList2.Add(111);    // casting form int(value type) to object(reference type)   boxing
			arrayList2.Add(222);
			arrayList2.Add(333);
			//arrayList2.Add("Mahmoud");   // compiler can't enforce type safety

			int res = SumArray(arrayList2);

			Console.WriteLine(res);

            Console.WriteLine();

			ArrayList arrayList3 = new ArrayList() { 100, "Mahmoud", 7.7, 123456789123456 };
			foreach(int num in arrayList3)
			{
				Console.WriteLine(num);
			}
            #endregion

        }
	}
}
