namespace Demo_4
{
    //1. Class   -> contain Function
    //2. Struct  -> contain Function
    //3. Interface  -> contain Function
    //4. Enum
    internal class Program
    {
        //static void PrintShape()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("*_*");
        //    }
        //}

        //static void PrintShape(int count)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine("*_*");
        //    }
        //}

        //static void PrintShape(int count, string Pattern)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(Pattern);
        //    }
        //}


        //static int Summation(int X, int Y)
        //{
        //    return X + Y;
        //}

        //passing value by value
        //static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //}
        //

        //passing value by ref
        //static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}


        //passing ref by value
        //static int Sum(int[] Arr)
        //{
        //    int sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}


        //passing ref by ref
        //static int Sum(ref int[] Arr)
        //{
        //    int sum = 0;
        //    Arr[0] = 100;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}

        //passing ref by value
        //static int SumArray(int[] Arr)
        //{
        //    int sum = 0;

        //    Arr = new int[]{5, 6, 7 };
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}


        //passing ref by Ref
        //static int SumArray( ref int[] Arr)
        //{
        //    int sum = 0;

        //    Arr = new int[] { 5, 6, 7 };
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        sum += Arr[i];
        //    }
        //    return sum;
        //}


        //Params
        //static int SumArr(params int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}






        static void Main(string[] args)
        {

            #region  One D Array

            //int[] Numbers;
            //Declare for Reference (Pointer) From type "Array of intgers"
            // Numbers: can refer to objevt from type "Array of intgers"
            // Numbers: refer to Null

            // 8 bytes will Allocate in stack
            // 0 bytes will be Allocate in heap


            //Numbers = new int[5];
            //new
            //Allocate the number of equired bytes for object in Heap
            //Intialized the Allocated Bytes with Default value of datatypes
            //call user defeind constructor if exsits
            //Assign the object to the Refrence Numbers

            //Console.WriteLine(Numbers[0]);  // 0 -> defult value

            //Numbers[0] = 2;
            //Numbers[1] = 5;
            //Numbers[2] = 3;
            //Numbers[3] = 7;
            //Numbers[4] = 9;

            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);
            //Console.WriteLine(Numbers[2]);
            //Console.WriteLine(Numbers[3]);
            //Console.WriteLine(Numbers[4]);

            //int[] Values = { 1, 2, 3, 4 };
            //int[] Values2 = new int[4]{ 1,2, 3, 4 };
            //int[] Values3 = new int[]{1,2, 3, 4 };
            //int[] Values4 = new int[5];

            //==============================

            //Console.WriteLine("Enter NUm 0");
            //Numbers[0] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter NUm 1");
            //Numbers[1] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter NUm 2");
            //Numbers[2] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter NUm 3");
            //Numbers[3] = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter NUm 4");
            //Numbers[4] = int.Parse(Console.ReadLine());

            //====================================

            //for (int i = 0; i < Numbers.Length; i++)
            //{ 
            //    Console.WriteLine($"Enter Value of Numbers[{i}]");
            //    Numbers[i] = int.Parse( Console.ReadLine() );
            //}
            //Console.WriteLine("================");
            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"{Numbers[i]}");

            //}

            //===============

            //Console.WriteLine(Numbers.Length);   //Size
            //Console.WriteLine(Numbers.Rank);   //Dimension


            #endregion

            #region Two D Array - Rectangle

            //int[,] Marks = new int[3, 3];

            //for (int i = 0; i < 3; i++) 
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter Marks[{i},{j}]:  ");
            //        Marks[i, j] = int.Parse( Console.ReadLine() );

            //    }


            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($" {Marks[i,j]} ");

            //    }
            //    Console.WriteLine();


            //}

            #endregion

            #region Two D Array - Jagged Array
            // number of row and columns not equal
            //int[][] Marks = new int[3][];

            //Marks[0] = new int[2];
            //Marks[1] = new int[4];
            //Marks[2] = new int[3];

            //for (int i = 0; i < 3; i++) 
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"Enter Marks[{i}][{j}] : ");
            //        Marks[i][j] = int.Parse(Console.ReadLine());

            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < Marks[i].Length; j++)
            //    {
            //        Console.Write($"{Marks[i][j]}");
            //        Console.Write(" ");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Functions Prototype And Calling

            //Function : Block of Code that Have a Name if U need to Excute the Code
            // U need To Call Nmae of Function
            // DRY
            //=====================

            //Fuction Prototype
            //1. Signature
            //   1.1 Name
            //   1.2 ReturnType
            //   1.3 Paramter(Inputs)

            //2.Body(code)

            //==================
            // Call Function 
            // PrintShape(); //without pramater
            // PrintShape(5);  //with paramter
            //PrintShape(5,"%_&");  // passing by order
            //PrintShape(Pattern:"%_&", count:4);  // passing by Name

            //==================
            //Methods
            //1. Class Member Methods  (Static)
            //2. Object Member Methods (Non Static)


            #endregion

            #region Passing Parameters - Value Type 
            //1.Passing by Value

            //int A = 5, B = 8;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("After Swapping:===============");

            //Swap(A, B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");


            //==================================================

            //2.Passing by Refrence

            //int A = 5, B = 8;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("After Swapping:===============");

            //Swap(ref A, ref B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            #endregion

            #region Passing Parameters - Reference Type Ex01 
            //1. Passing By Value
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine($"Sum of Array is: {Sum(Numbers)}");
            //Console.WriteLine(Numbers[0]);


            //2.Passing by Reference
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine($"Sum of Array is: {Sum(ref Numbers)}");
            //Console.WriteLine(Numbers[0]);


            #endregion

            #region Passing Parameters - Reference Type Ex02
            //1.passing ref by value
            //int[] Num = { 1, 2, 3 };
            //Console.WriteLine(SumArray(Num));  //passing by value

            //Console.WriteLine(Num[0]);


            //1.passing ref by ref
            //int[] Arr = { 1, 2, 3 };
            //Console.WriteLine(SumArray(ref Arr));
            //Console.WriteLine(Arr[0]);
            #endregion

            #region Passing By Out

            #endregion

            #region Params

            //int[] Numbers = { 1, 2, 3, 4 };
            //Console.WriteLine(SumArr(1, 2, 3, 4, 5, 7, 7, 8));



            #endregion

        }

    }
}
