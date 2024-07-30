using Swap;

namespace SearchExample
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Search Example

			int[] numbers = { 11, 2, 43, 54, 5, 63, 87, 8, };

			int pos = Helper<int>.SearchArray(numbers, 5);
			Console.WriteLine(pos);
			Console.WriteLine();


			Employee emp1 = new Employee(10, "Ahmed", 10000);
			Employee emp4 = new Employee(10, "Ahmed", 10000);
			Employee emp2 = new Employee(20, "ali", 20000);
			Employee emp3 = new Employee(30, "Omar", 70000);

			//if (emp1 == emp4)
			//{
			//             Console.WriteLine("Equals");
			//         }

			if (emp1.Equals(emp4))
			{
				Console.WriteLine("Equals");
			}
			else
			{
				Console.WriteLine("Not Equals");
			}
			Console.WriteLine();


			Employee[] employees =
			{
				emp4 ,
				emp2 ,
				emp3 ,
			};

			int index = Helper<Employee>.SearchArray(employees, new Employee(30, "Omar", 70000));
			Console.WriteLine(index);

			#endregion

		}
	}
}
