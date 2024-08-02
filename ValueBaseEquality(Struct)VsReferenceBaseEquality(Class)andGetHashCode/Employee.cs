using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueBaseEquality_Struct_VsReferenceBaseEquality_Class_andGetHashCode
{
	public class Employee
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
            return $"{ID} - {Name} - {Salary}";
        }


    }
}
