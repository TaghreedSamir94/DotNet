using System.ComponentModel.Design;
using System.Text;

namespace Demo_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Formatting
            
            int X = 4, Y = 3;
            //1. String Concatination
            //String Msg = "Equation: " + X + " + " + Y + " = " + (X + Y);
            //Console.WriteLine(Msg);

            //String : Immutable Datatype which can't Change its value after Creation
            //when change it mean create anathor object

            //==============
            //2. String Format

            //String Msg = String.Format("Equation: {0} + {1} = {2}", X, Y, (X + Y));
            //Console.WriteLine(Msg);

            //  Format deal with string as one object
            //  performance better than concatination

            //==============
            //3. String Interpolation
            //Syntax Sugar

            //String Msg = $"Equation: {X} + {Y} = {X + Y}";
            //Console.WriteLine(Msg);
            #endregion


            #region Control Statment

            // Control Statment :
            //1. Conditional Control Statment (If - Switch)
            //2. Looping Control Statment (For - Foreach - While - Dowhile)
            #endregion


            #region Conditional Control Statment

            //1. Using If
            //Console.Write("Enter Num of Month in 1st Qurter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            // If( Boolen Experisson )
            /*  {
             *    code
             *    // this code will excute when expression is true
             *  }

             */



            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Mar");
            //}




            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Jan");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Feb");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid num");
            //}


            //=====================
            //2. Using switch

            //Console.Write("Enter Num of Month in 1st Qurter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //switch (MonthNumber) 
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid num");
            //        break;

            //}


            #endregion


            #region Conditional Control Statment [String DataType]

            //// If
            //Console.Write("Enter Name : ");
            //String Name = Console.ReadLine();
            //if (Name == "Ahmed" || Name == "ahmed")
            //{
            //    Console.WriteLine("Hi Ahmed");
            //}
            //else if (Name == "Taghreed" || Name == "taghreed")
            //{
            //    Console.WriteLine("Hi Taghreed");
            //}

            //========

            //Switch
            //Console.Write("Enter Name : ");
            //String Name = Console.ReadLine();

            //switch (Name) 
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("Hi Ahmed");
            //        break;
            //    case "Taghreed":
            //    case "taghreed":
            //        Console.WriteLine("Hi Taghreed");
            //        break;
            //    default:
            //        Console.WriteLine("invalid");
            //        break;

            //}
            #endregion


            #region Switch [Numeric Datatypes (Comparsion Operators)]
            //Console.Write("Enter Your Age: ");
            //int Age = int.Parse(Console.ReadLine());

            //if (Age > 18)
            //{
            //    Console.WriteLine("Welcome :)");
            //}
            //else if (Age < 18)
            //{
            //    Console.WriteLine("BYe Bye :(");
            //}
            //else
            //{
            //    Console.WriteLine("Equal ;)");
            //}

            //=============

            //switch(Age)
            //{
            //    case > 18: 
            //        Console.WriteLine("Welcome :)");
            //        break;
            //    case < 18:
            //        Console.WriteLine("BYe Bye :(");
            //        break;
            //    default:
            //        Console.WriteLine("Equal ;)");
            //        break;
            //}


            #endregion


            #region Evolution of Switch in C# 7.0
            //object obj = new object();
            //obj = "Ahmed";
            //obj = 1;

            ////matching patteren

            //switch (obj)
            //{
            //    case int X when X > 0:
            //        Console.WriteLine("int object");
            //        break;
            //    case string X when X.Length > 4:
            //        Console.WriteLine("String Object");
            //        break;


            //}
            #endregion


            #region Evolution of Switch in C# 8.0

            //String Input = Console.ReadLine();

            //Console.WriteLine(Input switch
            //{
            //    "1" => "option 1",
            //    "2" => "option 2",
            //    "3" => "option 3",
            //    "4" => "option 4",
            //    _ => "Unsupport OPtion"

            //});

            #endregion


            #region Loop Statements - For, Foreach
            //int[] Numbers = { 1, 2, 3, 4, 5 };

            //1. For 
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //2.Foreach
            //foreach (int i in Numbers)
            //{
            //    Console.WriteLine(i);
            //}    
            #endregion

            #region Loop Statements - Do While, While
            //3. while

            //int I = 10;

            //while(I <= 20)
            //{ 
            //   Console.WriteLine(I);
            //    I++;
            //}

            //4. do while

            //do 
            //{
            //    Console.WriteLine("Hllo World");
            //}
            //while (I <10);

            //int Num;
            //bool Flag;
            //do
            //{
            //    Console.Write("Enter Even Num: ");
            //    Flag = int.TryParse(Console.ReadLine(), out Num);
            //}
            //while (Num % 2 != 0 || Flag == false);

            #endregion

            #region String
            //String :Reference type - Heap(class)
            // Immutable Type : Can't cahange its Value after creation

            // string S1;  //Declare for Reference(Pointer) From Type string
            //S1: Can Refer to object from 'String'
            //S1 : refer to null
            // 8 bytess will allocated at Stack for Reference S1
            // 0 bytes will allocated at Heap for 

            //S1 = new string("Ahmed");    /*---- > Syntax Sugar : */ S1 = "Ahmed"
            //new
            //1. Allocate Number Of Required Bytes For the Object At Heap
            //2. Intialize The allocated bytes with the default Value
            //3. Call user defined Constructor is Exist
            //4. Assign the Object To the References

            //=================================
            //String Msg = "hello ";
            //Console.WriteLine("Message : " + Msg);
            //Console.WriteLine("Hashcode : " + Msg.GetHashCode());


            //Msg += "Ahmed";
            //Console.WriteLine("Message: " + Msg);
            //Console.WriteLine("Hashcode: " + Msg.GetHashCode());

            #endregion

            #region String Builder
            // String Builder : class(Reference Type) : Heap
            // Mutable Type : Can Change Its Value after Creation

            //StringBuilder Sb;
            //Declare for Reference(Pointer) From Type 'StringBuilder'
            //Sb: Can Refer to object from 'StringBuilder'
            //Sb : refer to null

            //Sb = new StringBuilder("Hello");
            //new
            //1. Allocate Number Of Required Bytes For the Object At Heap
            //2. Intialize The allocated bytes with the default Value
            //3. Call user defined Constructor is Exist
            //4. Assign the Object To the References

            //Console.WriteLine("Sb : " + Sb);
            //Console.WriteLine("Hashcode : " + Sb.GetHashCode());
            //Console.WriteLine();

            //Sb.Append("Ahmed");
            //Console.WriteLine("Sb : " + Sb);
            //Console.WriteLine("Hashcode : " + Sb.GetHashCode());


            #endregion

        }
    }
}
