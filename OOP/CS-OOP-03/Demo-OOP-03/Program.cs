using Demo_OOP_03.Interface_EX01;
using Demo_OOP_03.Interface_Ex02;
using Demo_OOP_03.Interface_Ex03;

namespace Demo_OOP_03
{
    internal class Program
    {
        //static void Print10Number(ISeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current} ");
        //        series.Next();  
        //    }
        //    Console.WriteLine();
        //    series.Reset();

        //}
        static void Main(string[] args)
        {
            #region 02 Interface Ex01
            // Interface: ReferenceType
            // Code Contract between Developer who write it and Developer who use it [Implementation]

            //Note:👉👉 Can't Create Object from Any Interfaces 
            //Note:👉👉 Can Create Reference from Any Interfaces 

            //MyType t = new MyType();
            //t.MyFun();
            //t.Age = 24;
            //Console.WriteLine(t.Age);

            //IMyType T;
            // Ref can Refer to object From Any Class Which Implemented the Interface "IMyType"

            //T = new MyType();
            //T.MyFun();
            //T.Print();



            #endregion

            #region 03 Interface Ex02

            //SeriesByTwo seriesByTwo = new SeriesByTwo();
            //SeriesByThree seriesByThree = new SeriesByThree();
            //SeriesByFour seriesByFour = new SeriesByFour();
            //Print10Number(seriesByTwo);
            //Print10Number(seriesByThree);
            //Print10Number(seriesByFour);

            #endregion

            #region 04 Interface Ex03
            //Car c = new Car();
            //c.Speed = 120;
            //c.Forward();

            //AirPlane airPlane = new AirPlane();
            //IMoveable moveable = airPlane;
            //IFlyable flyable = airPlane;
            //moveable.Backward();
            //flyable.Forward();
            #endregion

            #region 05 Shallow Copy Vs Deep Copy
            //Any Ref Cosist Of : Identity(Address) + ObjectState(Data)



            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 14, 5, 6 };

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            //Console.WriteLine("=================");

            //1.Shallow Copy
            //Copy Identity
            //{ 1, 2, 3 } ==> Has Two Refrences Arr01, Arr02
            //{ 14, 5, 6 } ==> Unreachable Object

            //Arr01 = Arr02;
            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);

            //=============================

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 14, 5, 6 };

            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());
            //Console.WriteLine("=================");

            ////2.Deep Copy
            ////
            //Arr02 = (int[])Arr01.Clone();
            ////Clone Method Will Copy the Object State Of The Caller
            ////Assign new Object To Arr02 ,Will Generate New Identity


            //Console.WriteLine(Arr01.GetHashCode());
            //Console.WriteLine(Arr02.GetHashCode());

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);





            #endregion

            #region 06 Built-in Interface - ICloneable
            //Employee E1 = new Employee(){ Id = 1, Name = "Ahmed", Age = 24, Salary = 12200};
            //Employee E2 = new Employee(){ Id = 2, Name = "Amr", Age = 20, Salary = 1300 };

            //Console.WriteLine(E1);
            //Console.WriteLine(E2);
            //Console.WriteLine("=================");
            //E1 = E2; // Shallow Copy 
            //Console.WriteLine(E1);
            //Console.WriteLine(E2);

            //E2 = (Employee)E1.Clone();  // 📢📢 Deep Copy Using Clone

            //Console.WriteLine(E1);
            //Console.WriteLine(E2);

            //E1 = new Employee(E2);       // 📢📢 Deep Copy Using Copy Constructor

            //Console.WriteLine(E1);
            //Console.WriteLine(E2);



            #endregion

            #region 07 Built-in Interface - ICompareable

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){ Id = 1, Name = "Ahmed", Age = 22, Salary = 12000},
            //    new Employee() { Id = 2, Name = "Amr", Age = 20, Salary = 10000 },
            //    new Employee() { Id = 3, Name = "Ziad", Age = 23, Salary = 1100 }
            //};

            //Array.Sort(employees);

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}                                 //❌❌❌❌ returm Exception before using Interface Icomparable


            //int X = employees[1].CompareTo(employees[0]);
            //Console.WriteLine(X);


            //Array.Sort(employees);

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}                                 //✔✔✔✔ return Arry sorted Asc Based on Age After using Interface Icomparable
            #endregion


            #region 08 Built-in Interface - IComparer

            //Employee[] employees = new Employee[3]
            //{
            //    new Employee(){ Id = 1, Name = "Ahmed", Age = 22, Salary = 12000},
            //    new Employee() { Id = 2, Name = "Amr", Age = 20, Salary = 10000 },
            //    new Employee() { Id = 3, Name = "Ziad", Age = 23, Salary = 1100 }
            //};

            //Array.Sort(employees, new EmployeeCompereSalary());

            //foreach (Employee item in employees)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
