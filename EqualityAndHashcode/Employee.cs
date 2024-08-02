using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualityAndHashcode
{
	internal class Employee
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


		public override bool Equals(object? obj)
		{
			//Employee employee = (Employee)obj;

			Employee? employee = obj as Employee;
			if (employee is null)
			{
				return false;
			}

			return ID == employee.ID && Name == employee.Name && Salary == employee.Salary;
		}

		public override int GetHashCode()
		{
			//return ID.GetHashCode() ^ Name.GetHashCode() ^ Salary.GetHashCode();
			return HashCode.Combine(ID,Name, Salary);
		}

		public override string ToString()
		{
			return $" {ID} - {Name} - {Salary}";
		}
	}
}
