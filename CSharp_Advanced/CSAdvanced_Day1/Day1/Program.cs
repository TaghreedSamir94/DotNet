namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01 Generics - SWAP Example
            //Generic:
            //C# Feature 2005 C# 2.0
            //Befoe 2005 used Class Object

            // Static class : cant create object from it 

            // ************ Swap using non generic ************

            //int A = 1;
            //int B = 2;
            //Console.WriteLine($"A:{A}, B:{B}");
            //Console.WriteLine("*************AfterSwapping***************");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"A:{A}, B:{B}");


            //double l = 9.8;
            //double k = 3.4;
            //Console.WriteLine($"L:{l}, K:{k}");
            //Console.WriteLine("*************AfterSwapping***************");
            //Helper.Swap(ref l, ref k);
            //Console.WriteLine($"L:{l}, K:{k}");


            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(2, 3);
            //Console.WriteLine($"P1:{P1}, P2:{P2}");
            //Console.WriteLine("*************AfterSwapping***************");
            //Helper.Swap(ref P1, ref P2);
            //Console.WriteLine($"P1: {P1}, P2:{P2}");

            // ************ Swap using Generic ************

            //int A = 1;
            //int B = 2;
            //Console.WriteLine($"A:{A}, B:{B}");
            //Console.WriteLine("*************AfterSwapping***************");
            //Helper.Swap(ref A, ref B);
            //Console.WriteLine($"A:{A}, B:{B}");

            //Console.WriteLine("****************************");

            //double l = 9.8;
            //double k = 3.4;
            //Console.WriteLine($"L:{l}, K:{k}");
            //Console.WriteLine("*************AfterSwapping***************");
            //Helper.Swap(ref l, ref k);
            //Console.WriteLine($"L:{l}, K:{k}");

            //Console.WriteLine("****************************");

            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(2, 3);
            //Console.WriteLine($"P1:{P1}, P2:{P2}");
            //Console.WriteLine("*************AfterSwapping***************");
            //Helper.Swap(ref P1, ref P2);
            //Console.WriteLine($"P1: {P1}, P2:{P2}");


            #endregion

            #region 02 Generics - LinearSearch Exmaple
            //-----Without Generic Method
            //int[] Arr = { 1, 5, 6, 7, 8, 9, 10, 11, -3, 0 };
            //int Indexer =  Helper.LinearSearch(Arr, 8);
            //Console.WriteLine($"Found in Index: {Indexer}");

            //-----With Generic Method
            //Employee emp1 = new Employee() {ID = 1,Age = 20, Name = "Alaa", Salary = 2000};
            //Employee emp2 = new Employee() {ID = 2,Age = 22, Name = "Aml", Salary = 3500};
            //Employee emp3 = new Employee() {ID = 3,Age = 30, Name = "Doaa", Salary = 2300};
            //Employee emp4 = new Employee() {ID = 4,Age = 25, Name = "Aser", Salary = 2500};

            //Employee[] Employees = { emp1, emp2, emp3, emp4 };
            //int Indexer = Helper.LinearSearch(Employees, emp3);
            //Console.WriteLine($"Found in Index: {Indexer}");
            #endregion

            #region 03 Equality (Class and Struct)
            //Equality in class or Struct
            //Equals
            //'Class' Has Equals Function Which Inherited from Object Class --> Compare References(Address) -- (== operator make this too)          
            //'Struct' Has Equals Function Which Inherited from Object Class --> Compare Data
            //Note : Struct ont have Implementation for == operator

            // -- Employee is Class here
            //Employee emp1 = new Employee() { ID = 1, Age = 20, Name = "Alaa", Salary = 2000 };
            //Employee emp2 = new Employee() { ID = 1, Age = 20, Name = "Alaa", Salary = 2000 };

            //if (emp1.Equals(emp2))
            //{
            //    Console.WriteLine("E01 == E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01 != E02");
            //}

            //if (emp1 == emp2)
            //{
            //    Console.WriteLine("E01 == E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01 != E02");
            //}

            //-- Employee is Struct here

            //Employee emp1 = new Employee() { ID = 1, Age = 20, Name = "Alaa", Salary = 2000 };
            //Employee emp2 = new Employee() { ID = 2, Age = 20, Name = "Alaa", Salary = 2000 };

            //if (emp1.Equals(emp2))
            //{
            //    Console.WriteLine("E01 == E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01 != E02");
            //}

            //if (emp1 == emp2)  // used overloading operator 
            //{
            //    Console.WriteLine("E01 == E02");
            //}
            //else
            //{
            //    Console.WriteLine("E01 != E02");
            //}



            #endregion

            #region 04 Generics - BubbleSort Exmaple
            // using non generic
            //int[] Nums = { 1, 2, 55, 88, -2, 0, -5, 2, 8 };
            //Helper.PrintArr(Nums);
            //Console.WriteLine();
            //Helper.BubbleSort(Nums); 
            //Helper.PrintArr(Nums);

            // using generic
            //Point[] points =
            //{
            //    new Point(1,1),
            //    new Point(5,5),
            //    new Point(3,3),
            //    new Point(-1,-1),
            //};
            //Helper.PrintArr(points);
            //Console.WriteLine();

            //Helper.BubbleSort(points);
            //Helper.PrintArr(points);


            #endregion

            #region 05 is And as Operators

            //Point p1 = new Point(2, 2); 
            //Point p2 = new Point(3, 2);

            //if (p1.CompareTo(p2) > 0)
            //{
            //    Console.WriteLine("P1 greater than P2");
            //}
            //else
            //{
            //    Console.WriteLine("P1 less than P2");
            //}

            //if (p1.CompareTo(null) > 0)
            //{
            //    Console.WriteLine("P1 greater than P2");
            //}
            //else
            //{
            //    Console.WriteLine("P1 less than P2");
            //}

            //if (p1.CompareTo("Ahmed") > 0)
            //{
            //    Console.WriteLine("P1 greater than P2");
            //}
            //else
            //{
            //    Console.WriteLine("P1 less than P2");
            //}

            #endregion

            #region 06 IComparable Vs Generic IComparable

            //Point[] points =
            //{
            //    new Point(1,1),
            //    new Point(5,5),
            //    new Point(3,3),
            //    new Point(-1,-1),
            //};
            //Helper.PrintArr(points);
            //Console.WriteLine();

            //Helper.BubbleSort(points);
            //Helper.PrintArr(points);


            #endregion

            #region 07 Built-in Interface Generic IEquatable

            //Employee emp1 = new Employee() { ID = 1, Age = 20, Name = "Alaa", Salary = 2000 };
            //Employee emp2 = new Employee() { ID = 1, Age = 20, Name = "Alaa", Salary = 2000 };

            //if (emp1.Equals(null))
            //{
            //    Console.WriteLine("E1 == E2");
            //}
            //else
            //{
            //    Console.WriteLine("E1 != E2");
            //}


            #endregion

            #region 08 Built-in Interface Generic IEqualityComparer

            //Employee emp1 = new Employee() { ID = 1, Age = 20, Name = "Alaa", Salary = 2000 };
            //Employee emp2 = new Employee() { ID = 2, Age = 22, Name = "Aml", Salary = 3500 };
            //Employee emp3 = new Employee() { ID = 3, Age = 30, Name = "Doaa", Salary = 2300 };
            //Employee emp4 = new Employee() { ID = 4, Age = 25, Name = "Aser", Salary = 2500 };

            //Employee[] Employees = { emp1, emp2, emp3, emp4 };
            //int Indexer = Helper.LinearSearch(Employees, new Employee() { Name = "Aml" },new EmployeeEqualityComparorName() );
            //Console.WriteLine($"Found in Index: {Indexer}");

            #endregion

            #region 09 IComparer With Bubble Sort

           // Employee emp1 = new Employee() { ID = 1, Age = 20, Name = "Alaa", Salary = 2000 };
           // Employee emp2 = new Employee() { ID = 2, Age = 22, Name = "Aml", Salary = 3500 };
           // Employee emp3 = new Employee() { ID = 3, Age = 30, Name = "Doaa", Salary = 2300 };
           // Employee emp4 = new Employee() { ID = 4, Age = 25, Name = "Aser", Salary = 2500 };

           // Employee[] Employees = { emp1, emp2, emp3, emp4 };
           // Helper.PrintArr(Employees);
           // // Helper.BubbleSort(Employees); // based on Age
           // //Helper.BubbleSort(Employees, new EmployeeCompererSalary()); // based on salary
           //// Helper.BubbleSort(Employees, new EmployeeCompererNameLength());  // based on name length 
           // Helper.PrintArr(Employees);


            #endregion

            #region 10 Generic Constraints

            #endregion
        }
    }
}
