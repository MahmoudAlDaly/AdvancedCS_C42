using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
	public static class Helper<T> where T : class ,IComparable<T>     // Helper<T> // T on class level
	{
		#region Generaic constraint

		/// primary constraint [0 || 1]
		///		1. general primary constraint
		///			- class     => T must be class
		///			- struct    => T must be struct
		///			- notnull   => T must be class or struct not nullable
		///			- default   =>
		///			- unmanaged => 
		///		2. special primary constraint [user defined class and not sealed] <summary>
		///			- like point class => T must be point or another class inherits from point
		///			- Enum => T must be Enum

		/// secondary constraint [interface constrain] (0 to M)
		///		- Icomparable => T must be class or struct implementing IComparable<T> 

		/// parameterless constructor constraint [0 || 1]
		///		- can't use new() (constructor constraint) with struct 
		///		
		#endregion

		#region Non Generic Swap

		//public static void Swap(ref object x, ref object y)
		//{
		//	object Temp = x;
		//	x = y;
		//	y = Temp;

		//}

		#endregion

		// T Method Level
		public static void Swap(ref T x, ref T y)  // T on method level
		{
			T Temp = x;
			x = y;
			y = Temp;

		}

		public static int SearchArray(T[] arr,T value)
		{
			if (arr != null)
			{
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i].Equals(value))
					{
						return i;
					}
				}
			}
			return -1;
		}

		public static void BubbleSort(T[] arr)
		{
			if(arr != null)
			{
				for(int i = 0;i < arr.Length ; i++)
				{
					for (int j = 0; j < arr.Length - i - 1; j++)
					{
						//if (arr[j] > arr[j+1])
						if (arr[j].CompareTo(arr[j+1]) == 1)
						{
							Swap(ref arr[j], ref arr[j + 1]);
						}
					}
				}
			}

            foreach (T tt in arr)
			{
                Console.WriteLine($"{tt}, ");
            }

			Console.WriteLine();
		}
		


		#region Overloadin Swap

		//public static void Swap(ref double x, ref double y)
		//{
		//	double Temp = x;
		//	x = y;
		//	y = Temp;

		//}

		//public static void Swap(ref Point x, ref Point y)
		//{
		//          Console.WriteLine("___________Swap________________");
		//          Point Temp = x;
		//	x = y;
		//	y = Temp;

		//}

		#endregion

	}
}
