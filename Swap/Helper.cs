using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
	public class Helper<T>     // Helper<T> // T on class level
	{
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
