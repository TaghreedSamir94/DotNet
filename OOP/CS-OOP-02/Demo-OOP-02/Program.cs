using Demo_OOP_02.Binding;
using Demo_OOP_02.Inheritance;
using Demo_OOP_02.Overriding;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Demo_OOP_02
{
    
    internal class Program
    {
        #region  3.1 Polymoriphism Methods (Function) Overloading
        //static int sum(int x, int y)
        //{
        //    return x + y;
        //}

        //static double sum(double x, double y)
        //{
        //    return x + y;
        //}
        #endregion

        #region MyRegion
        //static void EmployeeProcess(FullTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }

        //}

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }

        //}

        static void EmployeeProcess(Employee employee)
        {
            if (employee is not null)
            {
                employee.Fun01();
                employee.Fun02();
            }

        }
        #endregion

        static void Main(string[] args)
        {
            #region 01 Class vs Struct
            // class vs struct
            // class : Reference Datatype --  object Store in Heap
            // struct: Value Datatype     --   object store in Stack

            // 4 principls of OOP apply in class
            // [ Encapsulation, part of polymoriphisim ] apply in struct

            // new in class : create object
            // new in struct : select constructor

            // Default constructor in class: do nothing
            // Default constructor in Struct: intialize attribute with default value

            // create any constructor in class:  default disable
            // create any constructor in struct: if paramterless => disable default, if paramter => dosnt affect on default

            //life time of object in struct is shorter than life time of object in Class

            // Access modifier in struct: 3 [ private, internal, public]
            // Access modifier in class: 6 [ private, internal, public, protected, internal protected, private protected]


            // if data is simple => struct
            // wen need to benifit with 4 principle of OOP use Class
            #endregion

            #region 02 Inheritance
            //Inheritinance: Use to achive DRY
            //Aplly on class only 

            // in C# No Multiple Inhirtinace - class have moro one Parent --not supported
            // multilevel -- Supported

            //Parent parent = new Parent(1, 2);
            //Console.WriteLine(parent);
            //parent.Fun01();
            //parent.Fun02();

            //📢📢📢📢📢📢📢
            // any Constructor in child will be Chain on Parameterless Constructor  of Parent
            // but if a Parameterize Constructor in Parent aParamterless id disable ,so Ctor in Child can't found any thing to chain on it
            // so we can solve this by change behavior of CTOR in child by make it chain on paramterize CTOR by using [bsae]

            //Child child = new Child(3,4,5);
            //Console.WriteLine(child);
            //child.Fun01();
            //child.Fun02();
            #endregion

            #region 04 Polymorphism Overview
            //3. Polymoriphism:
            //   3.1 Polymoriphism Methods (Function) Overloading
            //   3.2 Polymoriphism Methods (Function) Overriding

            #endregion

            #region 05 Polymorphism Methods Overloading

            // there are more than one Function[ in the same scope ] these have the same name but  Different Signature(Count - Type - Order) Paramter

            //Console.WriteLine(sum(5, 3));
            //Console.WriteLine(sum(5.5, 3.8));

            #endregion

            #region 06 Polymorphism Methods Overriding
            //There are more than one Function in different class or scope ,
            //these functions have the same name and same signature but with different behavior
            // must be a relationship between them inheritance

            //TypeB typeB = new TypeB() { A = 12, B = 13 }; //object intializer
            ////typeB.A = 11;
            ////typeB.B = 12;
            //typeB.Fun01();
            //typeB.Fun02();
            #endregion

            #region 07 What is Binding
            //Binding: 
            //Reference from Parent refer to objectof Child.

            //TypeA Ref;
            //Ref = new TypeA();  not binding

            // child is a parent 
            //TypeB is TypeA
            //
            //Ref = new TypeB(); binding
            //Ref.A = 1;
            // rferto every thing related to TypeA


            #endregion

            #region 08 Not Binding
            //TypeB Ref;
            //Ref = new TypeB();
            //Ref = new TypeA();  //❌❌❌

            //child is parent 

            //TypeA Ref = new TypeA();

            //TypeB B = (TypeB)Ref;  // NotBinding

            #endregion

            #region 09 When Need Binding
            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{ 
            //    Id = 1,
            //    Name = "Ahmed",
            //    Email = "A@gmail.com",
            //    Address = "Cairo",
            //    Salary = 54000
            //};

            //PartTimeEmployee partTime = new PartTimeEmployee()
            //{
            //    Id = 2,
            //    Name = "Aser",
            //    Email = "As@gmail.com",
            //    Address = "Alex",
            //    HourRate = 200,
            //    NumberOfHours = 20


            //};


            //EmployeeProcess(fullTime);
            //EmployeeProcess(partTime);
            //EmployeeProcess(null);
            //NullReference Exception


            #endregion

            #region 10 Binding Example
            //TypeA RefA;
            //RefA = new TypeA();
            //RefA = new TypeB();
            //RefA = new TypeC();
            //RefA = new TypeC();



            #endregion




            //================================================================
            #region Task
            //Protected: Acssible Within Same Class And Any Drived Class(same or different Assembly)
            //internal: Accessible only within the same assembly
            //internal Protected: Combinig Internal and Protected ,Acssible within  the same assembly and by derived classes in other assemblies.
            //Private Protected: more restrictive version of internal Protected, Accessible within the same class and by derived classes within the same assembly


            #endregion
        }
    }
}
