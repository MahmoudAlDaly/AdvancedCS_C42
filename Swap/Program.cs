using System.Xml.Linq;

namespace Swap
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Non Generic Swap

			//object a = 10;
			//object b = 7;

			//Console.WriteLine($"A = {a}");
			//Console.WriteLine($"B = {b}");

			//Console.WriteLine("___________________________");

			//Helper.Swap(ref a, ref b);
			//Console.WriteLine($"A = {a}");
			//Console.WriteLine($"B = {b}");

			//Console.WriteLine("___________________________");

			//object d = 7.7;  //boxing
			//object c = 10.10;
			//Console.WriteLine($"D = {d}");
			//Console.WriteLine($"C = {c}");

			//Console.WriteLine("___________________________");

			//Helper.Swap(ref d, ref c);
			//Console.WriteLine($"D = {d}");
			//Console.WriteLine($"C = {c}");

			//Console.WriteLine("____________________________");

			//object p1 = new Point(3, 5);  //boxing
			//object p2 = new Point(7, 9);

			//Console.WriteLine($"p1 = {p1}");
			//Console.WriteLine($"p2 = {p2}");

			//Console.WriteLine("____________________________");

			//Helper.Swap(ref p1, ref p2);

			//Console.WriteLine($"p1 = {p1}");
			//Console.WriteLine($"p2 = {p2}");

			#endregion

			#region Generic Swap

			int a = 10;
			int b = 7;

			Console.WriteLine($"A = {a}");
			Console.WriteLine($"B = {b}");

			Console.WriteLine("___________________________");

			//Helper.Swap<int>(ref a, ref b);  // where T on method level no need to define where method calling
			//Console.WriteLine($"A = {a}");
			//Console.WriteLine($"B = {b}");

			Console.WriteLine("___________________________");

			double d = 7.7;
			double c = 10.10;
			Console.WriteLine($"D = {d}");
			Console.WriteLine($"C = {c}");

			Console.WriteLine("___________________________");

			//Helper<double>.Swap(ref d, ref c);   // / where T on Class level need to define <T> before method calling
			Console.WriteLine($"D = {d}");
			Console.WriteLine($"C = {c}");

			Console.WriteLine("____________________________");

			Point p1 = new Point(3, 5);
			Point p2 = new Point(7, 9);

			Console.WriteLine($"p1 = {p1}");
			Console.WriteLine($"p2 = {p2}");

			Console.WriteLine("____________________________");

			//Helper.Swap<Point>(ref p1, ref p2);

			//Console.WriteLine($"p1 = {p1}");
			//Console.WriteLine($"p2 = {p2}");

			#endregion



		}
	}
}
