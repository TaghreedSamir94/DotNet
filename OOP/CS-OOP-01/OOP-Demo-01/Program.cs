using System.Security.Cryptography;

namespace OOP_Demo_01
{
    //1. Class
    //2. Struct
    //3. Interfaces
    //4. Enum

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //Struct: ValuType => Stack

            //Point P1;
            //declare object from type 'Point'
            // P1: object
            // Alloate unitialized 8 bytes in Stack


            //Console.WriteLine(P1.X);  //Unassigned Feild of X;
            //Console.WriteLine(P1.Y);  //Unassigned Feild of X;

            //P1.X = 10;
            //P1.Y = 10;
            //Console.WriteLine(P1.X); //10
            //Console.WriteLine(P1.Y); //10

            //Point P1 = new Point();
            // // new : Used for Select Constructor

            // Console.WriteLine(P1.X); //0 : default value
            // Console.WriteLine(P1.Y); //0 : default value



            //Point P1 = new Point(1, 2);

            //Console.WriteLine(P1.X); //1 
            //Console.WriteLine(P1.Y); //2 

            //Console.WriteLine(P1); //OOP_Demo_01.Point

            //P1.PrintPoint();



            #endregion



            #region OOP Overview
            // OOP : Object Oriented Programming
            // Programming Paradaigm
            // OOP : Paradaigm used for Buld Any Business


            //Class: Blueprint of object
            //Object : Specific Instance From Class

            // 4 Pillars
            // ================
            // 1. Encapsulation
            // 2. Inheritance
            // 3. Polymorphism
            // 4. Abstraction

            #endregion



            #region Encapsulation using Setter Getter Methods
            //Encapsulation : Separate Data(Attributes) Definition from its Use
            //Applied on Calss || Struct


            //Employee -- id, name, salary
            //Employee E1 = new Employee();
            //=====Before Apply Encapsulation ======
            //1. End user Access data itself
            //2. No Data Validation
            //3. No Readonly Feild

            //E1.id = 1;
            //E1.name = "Ahmed";
            //E1.salary = 12000;
            //Console.WriteLine(E1.id);
            //Console.WriteLine(E1.name);
            //Console.WriteLine(E1.salary);


            //=====After Apply Encapsulation======
            //1. Make all Data(attributes) private
            //2. Access Data through 
            //2.1 Setter and Getter Methods
            //2.2 Properties

            //E1.SetId(1);
            //E1.SetName("Ahmed");
            //E1.SetSalary(2000);

            //Console.WriteLine(E1.GetSalary());
            //Console.WriteLine(E1.GetName());
            //Console.WriteLine(E1.GetId());


            /////=====================
            ///using paramterize constructor
            //Employee E2 = new Employee(2, "Ahmed", 12000);
            //Console.WriteLine(E2.GetSalary());
            //Console.WriteLine(E2.GetName());
            //Console.WriteLine(E2.GetId());
            //Console.WriteLine(E2);

            #endregion



            #region Encapsulation using Properties
            //Employee E = new Employee();
            //E.Id = 12;
            //E.Name = "Ahmed";
            //E.Salary = 12000;
            //E.Address = "Cairo";
            //Console.WriteLine(E.Id);
            //Console.WriteLine(E.Name);
            //Console.WriteLine(E.Salary);
            //Console.WriteLine(E.Address);

            #endregion



            #region Indexer
            //Indexer : Special Property

            //PhoneBook phoneBook = new PhoneBook(3);
            //phoneBook.AddPerson("Ahmed", 12345, 0);
            //phoneBook.AddPerson("Amged", 159876, 1);
            //phoneBook.AddPerson("Ali", 987456, 2);

            //Console.WriteLine(phoneBook.GetNumber("Ahmed"));
            //phoneBook.UpdateNumber("Ahmed",44920);
            //Console.WriteLine(phoneBook.GetNumber("Ahmed"));

            //Console.WriteLine(phoneBook.GetName(159876));
            //phoneBook.UpdateName(159876, "Omer");
            //Console.WriteLine(phoneBook.GetName(159876));


            //using indexer
            //Console.WriteLine(phoneBook["Ahmed"]);
            //phoneBook["Ahmed"] = 9202000;
            //Console.WriteLine(phoneBook["Ahmed"]);

            //Console.WriteLine(phoneBook[987456]);
            //phoneBook[987456] = "Aser";
            //Console.WriteLine(phoneBook[987456]);
            #endregion



            #region Class - Internal Constructor Chaining

            #endregion
        }
    }
}
