using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{

    internal class EmployeeEqualityComparorName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }


    internal class EmployeeCompererSalary : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }


    internal class EmployeeCompererNameLength : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x.Name.Length.CompareTo(y.Name.Length);
        }
    }

    internal class Employee : IEquatable<Employee>, IComparable<Employee>
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public String Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {ID}, Name: {Name}, Age: {Age}, Salary: {Salary}";
        }


        //public override bool Equals(object? obj)
        //{
        //    Employee Emp = (Employee)obj;
        //    return this == Emp ;
        //}

        public bool Equals(Employee? other)
        {
            if (other is null) return false; 
            return this == other ;
        }

        public int CompareTo(Employee? other)
        {
            if (other is not null)
            {
                return Age.CompareTo(other.Age);
            }
            return 1;
        }

        //operator Overloading

        public static bool operator == (Employee left, Employee right)
        {
            return left.ID == right.ID && left.Age == right.Age && left.Name == right.Name && left.Salary == right.Salary;
        }

        public static bool operator !=(Employee left, Employee right)
        {
            return left.ID != right.ID || left.Age != right.Age || left.Name != right.Name || left.Salary != right.Salary;
        }
    }
}
