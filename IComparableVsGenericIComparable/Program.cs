
using Swap;

namespace IComparableVsGenericIComparable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Point[] points =
			{
				new Point(40, 10),
				new Point(111, 80),
				new Point(100, 30),
				new Point(80, 20),
				new Point(45, 70),
			};

			Helper<Point>.BubbleSort(points);
		}
	}
}
