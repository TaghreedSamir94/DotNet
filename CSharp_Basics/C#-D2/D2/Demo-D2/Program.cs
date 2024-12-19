namespace Demo_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variable Declaration
            // //DataType variableName;
            // int Number;   //Declared Variable
            //// Console.WriteLine(Number); //invalid

            // Number = 0;
            // Console.WriteLine(Number);

            // int Num = 6;//Declaration and intialization in same line
            //             //varaible
            //             //Name: Number
            //             //DataType: int
            //             //Size : 4 bytes
            //             //Value : 6
            //             //Address: in hexadecimal
            #endregion

            #region CTS & CLS
            //CTS --- Common Type System
            //CLS --- Common Language Specification
            //Datatypes -- 1.ValueType(Primitive) --- 2.ReferenceType
            #endregion

            #region DataTypes

            #region Datatype(value type):Stack
            ////Datatype(value type):Stack

            //int Number01; //Value Type
            //              //Allocate Unintialized 4 bytes in stack
            //              // int : keyword in C#
            //              //BCL : int32

            //Number01 = 12;
            //Console.WriteLine(Number01);
            //Int32 Num02;
            ////Console.WriteLine(Num02); 
            #endregion

            #region DataType(RefrencesType):Heap

            //Point P01; //Refrence
            //// Declare Refrence From Type Point
            //// P01 can Refere to object from type 'Point'
            //// 8 byte will be Allocated At Stack for the 'P01'
            //// 0 byte will be Allocated At Heap 

            //P01 = new Point();
            //new
            //1. Allocate for the number of required bytes for the object in Heap
            //2. Intialized the allocated bytes with the defualt value of the DataType
            //3. call use defined constructor if exsits
            //4. Assign object Address to refrences

            //Console.WriteLine(P01.X); //0
            //Console.WriteLine(P01.Y); //0
            //Console.WriteLine(P01);   // namespace -- Demo_D2.Point

            //Point P02 = new Point();
            //P02.X = 12;

            //Console.WriteLine(P02.X);
            //Console.WriteLine(P01.X);

            //P01 = P02; 

            //Console.WriteLine(P02.X);
            //Console.WriteLine(P01.X);





            #endregion





            #endregion

            #region Object

            //object obj;
            ////Declare For Refrences from Type 'Object'
            ////obj : can refer to instance from type 'object' or any type inherited from object

            //obj = new object();

            //obj = 1;
            //Console.WriteLine(obj);
            //obj = 'A';
            //Console.WriteLine(obj);
            //obj = 1.5;
            //Console.WriteLine(obj);
            //obj = true;
            //Console.WriteLine(obj);
            //obj = new Point();
            //Console.WriteLine(obj); // Demo_D2.Point


            //Point P3 = new Point();
            ////P3.ToString();
            ////P3.GetType();
            ////P3.Equals();
            ////P3.GetHashCode();

            //Console.WriteLine(P3.ToString()); // = Console.WriteLine(P3); 
            //// defualt print namespace
            //// can use it to change behavior of it by override

            //Console.WriteLine(P3.GetHashCode());  // 43942917
            //// indicate Address of object as intger
            //// hashcode is unique for each object
            #endregion

            #region Casting
            // Casting : Convert from Datatype to Datatype
            //1. Implicit Casting
            // casting made internally by CLR without me
            //int X = 5;
            //double y = X;
            //Console.WriteLine(y);

            //2. Explicit Casting
            // casting made by me 
            //double X = 2.5;
            ////int y = X; //❌❌
            //int y = (int)X; //(unsafe)
            //Console.WriteLine(y);
            #endregion

            #region Parse,Convert,TryParse
            ////1.Parse : Function
            //Console.WriteLine("Enter Your Age:");
            //int Age = int.Parse(Console.ReadLine());
            //Console.WriteLine(Age);

            ////2.Convert : Class
            //Console.WriteLine("Enter Your Age:");
            //int Age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Age);

            ////3.TryParse: Function
            //Console.WriteLine("Enter Your Age:");
            //int Age;
            //bool Flag = int.TryParse(Console.ReadLine(), out Age);
            //Console.WriteLine(Age);



            #endregion

            #region Fraction & Discard
            //double X = 2.5;
            //float Y = 1.5F;
            //decimal Z = 1.5m;

            //int a = 1_000_000_000; // Discard _ to make num more readable 


            #endregion

            #region Operators
            ////1.Unary operator
            ////works on 1 operand (variable) ++, --
            //int X = 10;
            ////Suffix Increment var++, [Print then Increment]
            //Console.WriteLine(X++); //10

            ////Prefix Increment ++var, [Increment then print]
            //Console.WriteLine(++X); //12

            //================================================
            //2. Binary Operator  --> Works on 2 operands 
            // + = / * %

            //int sum, sub, mod, mul;

            //int num1 = 2, num2 = 6;

            //sum = num1 + num2; //8
            //sub = num1 - num2; //-4
            //mod = num1 % num2; //2
            //mul = num2 * num1; //12

            //Console.WriteLine(sum);
            //Console.WriteLine(sub);
            //Console.WriteLine(mod);
            //Console.WriteLine(mul);

            //===============================================

            ////3.Assignment operator

            //int x = 4;

            //x += 2; //6
            //x -= 2;  // x = x-2
            //x *= 2;  // x = x*2
            //x %= 2;  // x = x%2
            //x /= 2;  // x = x/2


            //===============================================

            //4. Relational Operator

            //int x = 4, y = 6;

            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x <= y);
            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);


            //===============================================

            //5. Logical Operator [And -  or - not]

            //Console.WriteLine(!false);
            //Console.WriteLine(false && true); // false // and short circut
            //Console.WriteLine(false || true); //true   // and short circut

            //===============================================

            //6. Bitwise Operator 

            //Console.WriteLine(!false); // true
            //Console.WriteLine(false & true); // false // and long circut
            //Console.WriteLine(false | true); //true   // and long circut

            //===============================================

            //7. Ternary Operator - [conditional operator] 
            //bool flag = 4 > 2;
            //Console.WriteLine(flag);


            //String flag2 = 4 > 2 ? "T" : "F";
            //Console.WriteLine(flag2);
            #endregion

            #region operator Priority [Precedence] and Associtvity
            /*
             * 1.unary operator(prefix)
             * 2.round praces()
             * 3.* / %
             * 4. + =
             */
            #endregion



        }
    }
}
