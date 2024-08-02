using EqualityAndHashcode;
using Swap;


namespace Generics_BubbleSortExmaple
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] arr = { 100,3,45,79,52,66,1,65,90};
			
			Helper<int>.BubbleSort(arr);

			EmployeeClass[] employee =
			{
				new EmployeeClass(1,"ali",10000),
				new EmployeeClass(2,"mai",50000),
				new EmployeeClass(3,"mona",3000),
			};

			Helper<EmployeeClass>.BubbleSort(employee);
		}
	}
}
