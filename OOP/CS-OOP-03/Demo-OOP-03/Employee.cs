using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_03
{
    class EmployeeCompereSalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;

            if(X.Salary > Y.Salary) return 1;
            else if (X.Salary < Y.Salary ) return -1;
            else return 0;
      
        }
    }
    internal class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public double Salary { get; set; }
        public int Age { get; set; }

        public Employee() 
        { 
        }
        //Copy Costructor
        public Employee(Employee emp) 
        { 
            Id = emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
            Age = emp.Age;

        }
        public object Clone()
        {
            //return new Employee() { Id = this.Id, Name = this.Name, Salary = this.Salary, Age = this.Age };
            // 👇👇 Syntax Sugar
            return new Employee(this);
        }

        public override string ToString()
        {
            return $"Id:{Id}, Name:{Name}, salary:{Salary}, Age:{Age}";
        }

        public int CompareTo(object? obj)
        {
            Employee e = (Employee)obj;

            //if (this.Age > e.Age) return 1;
            //else if (this.Age < e.Age) return -1;
            //else return 0;

            // 👇👇 Syntax Sugar

            return this.Age.CompareTo(e.Age);
        }
    }
}
