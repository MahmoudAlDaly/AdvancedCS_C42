using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
	public struct Employee
	{
        public int ID { get; set; }
		public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

		public override string ToString()
		{
			return $"id = {ID} , name = {Name} , salary = {Salary}";
		}

		public static bool operator ==(Employee left, Employee right)
		{
			return left.Equals(right);
			//return (left.ID == right.ID) && (left.Name == right.Name) && (left.Salary == right.Salary);
		}

		public static bool operator !=(Employee left, Employee right)
		{
			return !left.Equals(right);
			//return (left.ID != right.ID || left.Name != right.Name || left.Salary != right.Salary);
		}
	}
}
