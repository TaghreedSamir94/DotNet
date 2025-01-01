using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_01
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;


        #region Apply Encapsulation using setter getter methods
        ////1.Setter
        //public void SetId(int id)
        //{
        //    this.id = id;
        //}

        //public void SetName(string name)
        //{
        //    if (name.Length > 5 && name.Length <= 20)
        //    {
        //        this.name = name;
        //    }
        //}

        //public void SetSalary(double salary)
        //{
        //    if (salary > 0.0)
        //    {
        //        this.salary = salary;
        //    }

        //}


        ////2. Getter
        //public int GetId()
        //{ 
        //    return id;
        //}

        //public string GetName()
        //{
        //    return name;
        //}

        //public double GetSalary()
        //{
        //    return salary;
        //}



        ////paramterize Constructor

        //public Employee(int id, string name, double salary)
        //{
        //    SetId(id);
        //    SetName(name);
        //    SetSalary(salary);
        //}


        //public override string ToString()
        //{
        //    return $"id:{id}, name:{name}, salary:{salary}";
        //}
        #endregion

        #region Apply Encapsulation using Properties
        //Properties

        //1. Full Property
        //must private attribute exsits first
        //public + DataType of Feild i want to Access + NameOfProperty{Set{} get{} }
       
        //id
        //public int Id
        //{
        //    set
        //    {
        //        id = value;
        //    }
        //    get 
        //    {
        //        return id;
        //    }

        //}

        ////name
        //public string Name
        //{
        //    set
        //    {
        //        name = value;
        //    }
        //    get
        //    {
        //        return name;
        //    }
        //}

        ////salary
        //public double Salary
        //{
        //    set
        //    {
        //        if (value < 0)
        //            salary = value;
        //    }
        //    get
        //    {
        //        return salary;
        //    }

        //}

        //============================
        //2. Automatic Property
        // not need private attribute exists
        //public string Address { set; get; }

        //===================================
        //3. Special Property [indexer]
        #endregion

    }
}
