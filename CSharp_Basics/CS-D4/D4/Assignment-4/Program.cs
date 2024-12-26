namespace Assignment_4
{
    internal class Program
    {

        #region Func Q1

        //passing value by value
        //static void Swap(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //

        //passing value by ref
        //static void Swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion
        //============================
        #region Func Q2
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
        #endregion
        //============================
        #region Func Q3
        //static (double, double) SumAndSub(double X, double Y, double Z, double S)
        //{
        //    double Sum = X + Y ;
        //    double sub = Z - S; 

        //    return (Sum , sub);
        //}
        #endregion
        //============================
        #region Func Q4
        //static int SumDigit(int x)
        //{
        //    int Sum = 0;
        //    while (x > 0)
        //    {
        //        int digit = x % 10;
        //        x = x /10;  
        //        Sum += digit;
        //    }
        //    return Sum;
        //}
        #endregion
        //============================
        #region Func Q5
        //static void IsPrime(int X)
        //{
        //    bool Flag = true;
        //    if (X > 2)
        //    {
        //        for (int i = 2; i < X; i++)
        //        {
        //            if (X % i == 0)
        //            {
        //               Flag = false;
        //                break;
        //            }
        //        }
        //    }
        //    else if (X == 2)
        //    {
        //        Flag = true;
        //    }
        //    else
        //    {
        //        Flag = false ;
        //    }

        //    if (Flag)
        //    {
        //        Console.WriteLine($"{X} is a Prime Number");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{X} is not a Prime Number");
        //    }
        //}

        #endregion
        //============================
        #region Func Q6
        //static void MinMax(ref int[] Arr, out int min, out int max)
        //{
        //    min = 1000;
        //    max = 0;
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        if (Arr[i] > max)
        //        {
        //            max = Arr[i];
        //        }
        //        else if (Arr[i] < min)
        //        {
        //            min = Arr[i];
        //        }
        //    }


        //}
        #endregion


        static void Main(string[] args)
        {
            #region Q1
            /*1-Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.*/

            //1.pass value by value
            //Any changes made to the parameter inside the method do not affect the original variable.

            //int A = 5, B = 8;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("After Swapping:===============");

            //Swap(A, B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //2.pass value by ref
            // Changes made to the parameter inside the method do affect the original variable.

            //int A = 5, B = 8;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("After Swapping:===============");

            //Swap(ref A, ref B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            #endregion

            //============================
            #region Q2
            /*2-Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.*/
            //1.pass ref by value

            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine($"Sum of Array is: {Sum(Numbers)}");
            //Console.WriteLine(Numbers[0]);

            //pass ref by ref
            //int[] Numbers = { 1, 2, 3 };
            //Console.WriteLine($"Sum of Array is: {Sum(ref Numbers)}");
            //Console.WriteLine(Numbers[0]);


            #endregion

            //============================
            #region Q3
            /*3-Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers*/

            //Console.Write("Enter 1st Number: ");
            //double A = double.Parse(Console.ReadLine());

            //Console.Write("Enter 2nd Number: ");
            //double B = double.Parse(Console.ReadLine());

            //Console.Write("Enter 3rd Number: ");
            //double C = double.Parse(Console.ReadLine());

            //Console.Write("Enter 4th Number: ");
            //double D = double.Parse(Console.ReadLine());

            //(double Sum , double Sub) = SumAndSub(A, B, C, D);

            //Console.WriteLine($"Summion of first 2 numbers is : {Sum}");
            //Console.WriteLine($"Difference between Second 2 numbers is : {Sub}");
            #endregion

            //============================
            #region Q4
            /*1-Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
               Output should be like 
               Enter a number: 25                                                                                            
               The sum of the digits of the number 25 is: 7
             */

            //Console.Write("Enter a Number: ");
            //int Num = int.Parse(Console.ReadLine());

            //Console.WriteLine(SumDigit(Num));

            #endregion

            //============================
            #region Q5
            /*5-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:*/

            //Console.Write("Enter Number To check if Prime?:  ");
            //int Num = int.Parse(Console.ReadLine());

            //IsPrime(Num);

            #endregion

            //============================
            #region Q6
            /*6-Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters*/
            //int[] arr = { 1, 2, 5, 8, 20, 17, 0 };
            //int min, max;
            //MinMax(ref arr, out min, out max);
            //Console.WriteLine($"Min value in Array is :{min}");
            //Console.WriteLine($"Max value in Array is :{max}");

            #endregion

            //============================
            #region Q7
            /*7-Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter*/

            #endregion

            //============================
            #region Q8
            /*8-	Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter*/

            #endregion

            //============================
            #region Q9
            /*9- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.*/

            //Console.Write("Enter Size of Matrix: ");
            //int N = int.Parse(Console.ReadLine());

            //int[,] IdntityMatrix = new int[N, N];

            ////fill matrix
            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if(i == j)
            //        {
            //            IdntityMatrix[i, j] = 1;

            //        }
            //        else
            //        {
            //            IdntityMatrix[i, j] = 0;
            //        }
            //    }

            //}
            ////print matrix

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //       Console.Write($"{IdntityMatrix[i, j]}");
            //       Console.Write(' ');
            //    }
            //    Console.WriteLine();


            //}

            #endregion

            //============================
            #region Q10
            /*10-Write a program in C# Sharp to find the sum of all elements of the array.*/

            //Console.Write("Enter Size of Array: ");
            //int N = int .Parse(Console.ReadLine());
            //int[] arr = new int[N];
            //int Sum = 0;

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter value of arr[{i}]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    Sum += arr[i];

            //}
            //Console.WriteLine($"Sum is : {Sum}");






            #endregion

            //============================
            #region Q11
            /*11-Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.*/

            // Console.Write("Enter Size of Arr1: ");
            // int N1 = int.Parse(Console.ReadLine());

            //int[] Arr1 = new int[N1];

            //for (int i = 0; i < N1; i++)
            //{
            //    Console.Write($"Enter Value of Arr1[{i}]: ");
            //    Arr1[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("====================================");


            //Console.Write("Enter Size of Arr2: ");
            //int N2 = int.Parse(Console.ReadLine());
            //int[] Arr2 = new int[N2];
            //for (int i = 0; i < N2; i++)
            //{
            //    Console.Write($"Enter Value of Arr2[{i}]: ");
            //    Arr2[i] = int.Parse(Console.ReadLine());

            //}

            //if (N1 == N2)
            //{
            //    int[] MergedArr = new int[N1 + N2];
            //    Array.Copy(Arr1, MergedArr, Arr1.Length);
            //    Array.Copy(Arr2, 0, MergedArr, Arr1.Length, Arr2.Length);

            //    Array.Sort(MergedArr);

            //    Console.WriteLine("Sorted MergedArr: ");
            //    foreach(int i in MergedArr)
            //    {
            //        Console.Write($"{i} ");
            //    }

            //}
            //else 
            //{
            //    Console.WriteLine("Can't merge because size is not equal");
            //}


            #endregion

            //============================
            #region Q12
            /*12-Write a program in C# Sharp to count the frequency of each element of an array.*/
            //Console.Write("Enter Size of Arr: ");
            //int N = int.Parse(Console.ReadLine());
            //int[]Arr = new int[N];
            //int Count = 1;
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($" Value of Arr[{i}]: ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(Arr);
            //for (int i = 1; i <= N; i++)
            //{
            //    if (i < Arr.Length && Arr[i] == Arr[i - 1])
            //    {
            //        Count++;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Element {Arr[i-1]} repeated {Count} times");
            //        Count = 1;
            //    }

            //}
            #endregion

            //============================
            #region Q13
            /*13-Write a program in C# Sharp to find maximum and minimum element in an array*/

            //Console.Write("Enter Size of Arr: ");
            //int N = int.Parse(Console.ReadLine());
            //int[] Arr = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"Arr[{i}]: ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine($"Minimum Number in Array is: {Arr.Min()}");
            //Console.WriteLine($"Maximum Number in Array is: {Arr.Max()}");


            #endregion

            //============================
            #region Q14
            /*14-Write a program in C# Sharp to find the second largest element in an array.*/

            //Console.Write("Enter Size of Arr: ");
            //int N = int.Parse(Console.ReadLine());
            //int[] Arr = new int[N];
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"Enter Value of Arr[{i}]: ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(Arr);
            //Console.WriteLine($"Second Largest Number is: {Arr[N - 2]}");



            #endregion

            //============================
            #region Q15
            /*Consider an Array of Integer values with size N, having values as    
             in this Example
            write a program to find the longest distance between Two equal cells. 
            In this example. The distance is measured by the number Of cells- for example, 
            the distance between the first and the fourth cell is 2 (cell 2 and cell 3).
            */

            //Console.Write("Enter Size of Array: ");
            //int N = int.Parse(Console.ReadLine());
            //int[] Arr = new int[N];

            //int MaxDistance = 0;

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"Enter Value of Arr[{i}]: ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("==================================");

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = i + 1; j < N; j++)
            //    {
            //        if (Arr[i] == Arr[j])
            //        {
            //            int Distance = j - i - 1;

            //            if (Distance > MaxDistance)
            //            {
            //                MaxDistance = Distance;
            //            }
            //        }

            //    }
            //}
            //Console.WriteLine($"the longest distance between Two equal cells is : {MaxDistance}");




            #endregion

            //============================
            #region Q17
            /*17-Given a list of space separated words, reverse the order of the words.

              Input: this is a test		Output: test a is this
              Input: all your base		Output: base your all
              Input: Word			    Output: Word
             */

            //Console.Write("Enter Words: ");
            //string[] Word = Console.ReadLine().Split(" ");


            //Console.WriteLine("Reversed Words are : ");
            //for (int i = Word.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{Word[i]} ");
            //}

            #endregion

            //============================
            #region Q18
            /*18-Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array*/

            //Console.Write("Enter Num of Columns: ");
            //int Col = int.Parse(Console.ReadLine());

            //Console.Write("Enter Num of Rows: ");
            //int Row = int.Parse(Console.ReadLine());

            //int[,] Arr1 = new int[Row, Col];
            //int[,] Arr2 = new int[Row, Col];

            //for (int i = 0; i < Row; i++)
            //{
            //    for(int j = 0; j < Col; j++)
            //    {
            //        Console.Write($" Enter Value ofArr1[{i}, { j}]: ");
            //        Arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("====================");

            //Arr2 = Arr1;
            //Console.WriteLine("Array2 is : ");
            //for(int i = 0;i < Row; i++) 
            //{
            //    for (int j = 0;j < Col; j++)
            //    {
            //        Console.Write($"{Arr2[i, j]}");
            //        Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}





            #endregion

            //============================
            #region Q19
            /*19-Write a Program to Print One Dimensional Array in Reverse Order*/

            //Console.Write("Enter Size of Arr: ");
            //int N = int.Parse(Console.ReadLine());
            //int[] Arr = new int[N];

            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write($"Enter Value of Arr[{i}]: ");
            //    Arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine(" =============================");
            //Console.WriteLine("Reverse Array is: ");
            //for (int i = N-1; i >= 0; i--)
            //{
            //    Console.Write($"{Arr[i]}  ");

            //}
            #endregion

            //============================
        }
    }
}
