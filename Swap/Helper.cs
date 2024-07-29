using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
	internal class Helper
	{
        
		public static void Swap(ref int x,ref int y)
		{
			int Temp = x;
			x = y;
			y = Temp;

		}

		public static void Swap(ref double x, ref double y)
		{
			double Temp = x;
			x = y;
			y = Temp;

		}

		public static void Swap(ref Point x, ref Point y)
		{
            Console.WriteLine("___________Swap________________");
            Point Temp = x;
			x = y;
			y = Temp;

		}
	}
}
