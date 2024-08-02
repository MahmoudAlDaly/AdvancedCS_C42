namespace EqualityAndHashcode
{
	internal class Program
	{
		static void Main(string[] args)
		{


			#region Class
			EmployeeClass e1 = new EmployeeClass(1, "ali", 10000);
			EmployeeClass e2 = new EmployeeClass(1, "ali", 10000);

			Console.WriteLine($" e1 hashcode = {e1.GetHashCode()}");
			Console.WriteLine(e1);
			Console.WriteLine();
			Console.WriteLine($" e2 hashcode = {e2.GetHashCode()}");
			Console.WriteLine(e2);

			Console.WriteLine();
			Console.WriteLine($" Equals = {e1.Equals(e2)}");  // compare between object state with object state 
			#endregion



		}
	}
}
