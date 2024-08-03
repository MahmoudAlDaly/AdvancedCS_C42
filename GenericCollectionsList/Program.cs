using Swap;

namespace GenericCollectionsList
{
	internal class Program
	{
		public static int SumList(List<int> numbers)
		{
			int sum = 0;

			if (numbers != null)
			{
				for (int i = 0; i < numbers.Count; i++)
				{
					sum += numbers[i];
				}
			}

			return sum;
		}


		static void Main(string[] args)
		{
			List<int> numbers = new List<int>() { 10,8,6,9,7,15,2,45,43 };

            Console.WriteLine($"count = {numbers.Count}  cap = {numbers.Capacity}");

			numbers.Add(70);
			numbers.AddRange(new[]{ 90, 100 });
			numbers.AddRange(new[]{ 1,2,3,4 });
			numbers.AddRange(new[]{ 5 });

			numbers.TrimExcess();

			//ints.Add("ali"); // not valid

			Console.WriteLine($"count = {numbers.Count}  cap = {numbers.Capacity}");
            Console.WriteLine();

            foreach ( int i in numbers )
			{
				Console.Write($"{i} , ");
			}

			int r = SumList(numbers);
            Console.WriteLine();
            Console.WriteLine($" sum = {r}");
			Console.WriteLine();

			Console.WriteLine($" numbers[3] = {numbers[3]}"); // indexer as getter
			//Console.WriteLine($" numbers[4] = {numbers[4] = 73}"); // indexer can't use as setter

        }
	}
}
