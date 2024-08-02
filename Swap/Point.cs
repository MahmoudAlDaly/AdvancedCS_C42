using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
	public class Point  : IComparable<Point>
	{
        public int X { get; set; }
		public int Y { get; set; }

        public Point(int x , int y)
        {
            X = x;
            Y = y;
        }

		public override string ToString()
		{
			return $"{X},{Y}";
		}

		public int CompareTo(object? obj)
		{
			#region is
			////is operator return true in 3 cases
			////1 - obj is point
			////2 - obj is type inherits form point
			////3 - obj is null

			if (obj is Point point)
			{
				if (point is null)
				{
					return 1;
				}

				if (X == point.X)
				{
					return Y.CompareTo(point.Y);
				}
				else
				{
					return X.CompareTo(point.X);
				}
			}

			return 1;
			#endregion

			#region AS
			//Point? point = obj as Point;

			//if (point == null)
			//{
			//	return 1;
			//}

			//if (X == point.X)
			//{
			//	return Y.CompareTo(point.Y);
			//}
			//else
			//{
			//	return X.CompareTo(point.X);
			//} 
			#endregion
		}

		public int CompareTo(Point? other)
		{
			if (other is null)
			{
				return 1;
			}

			if (X == other.X)
			{
				return Y.CompareTo(other.Y);
			}
			else
			{
				return X.CompareTo(other.X);
			}
		}
	}
}
