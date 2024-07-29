namespace Swap
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 10;
			int b = 7;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");

            Console.WriteLine("___________________________");

            Helper.Swap(ref a,ref b );
			Console.WriteLine($"A = {a}");
			Console.WriteLine($"B = {b}");

			Console.WriteLine("___________________________");

			double d = 7.7;
			double c = 10.10;
			Console.WriteLine($"D = {d}");
			Console.WriteLine($"C = {c}");

			Console.WriteLine("___________________________");

			Helper.Swap(ref d, ref c);
			Console.WriteLine($"D = {d}");
			Console.WriteLine($"C = {c}");

            Console.WriteLine("____________________________");

			Point p1 = new Point(3,5);
			Point p2 = new Point(7,9);

			Console.WriteLine($"p1 = {p1}");
			Console.WriteLine($"p2 = {p2}");

			Console.WriteLine("____________________________");

			Helper.Swap(ref p1,ref p2);

			Console.WriteLine($"p1 = {p1}");
			Console.WriteLine($"p2 = {p2}");
		}
	}
}
