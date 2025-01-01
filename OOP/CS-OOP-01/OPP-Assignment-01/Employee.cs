using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Assignment_01
{
    public enum SecurityLevel
    {
        Guest,
        Developer, 
        Secretary,
        DBA,
        SecurityOfficer
    }
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public HiringDate HireDate { get; set; }
        public double Salary { get; set; }
        public SecurityLevel SecurityPrivileges {  get; set; }

        private char Gender;

        //gender
        public char _Gender
        {
            set 
            {
                if(value == 'M' || value == 'F')
                {
                    Gender = value;
                }
                else
                {
                    throw new ArgumentException("Gender must be M o F");
                }
               
            }
            get
            {
                return Gender;
            }
        }


        public Employee(int id, string name, HiringDate hireDate, double salary, SecurityLevel security, char gender)
        {
            ID = id;
            Name = name;
            HireDate = hireDate;
            Salary = salary;
            SecurityPrivileges = security;
            Gender = gender;
        }


        public override string ToString()
        {
            return string.Format("Id: {0}\n Name: {1}\n HireDate: {2}\n Salary: {3}\n SecurityLevel: {4}\n Gender: {5} ",
                ID,
                Name,
                HireDate.ToString(),
                Salary.ToString("C", CultureInfo.CurrentCulture),
                SecurityPrivileges,
                Gender == 'M'? "Male" : "Female"
                );
        }


    }
}
