namespace Assignment_D3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /* 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.*/

            //Console.Write("Enter a Number: ");
            //int X = int.Parse(Console.ReadLine());

            //if (X % 3 == 0 && X % 4 == 0)
            //{
            //    Console.WriteLine("Output : Yes");

            //}
            //else 
            //{
            //    Console.WriteLine("Output : No");
            //}


            #endregion

            //===========================
            #region Q2
            /*Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.*/

            //Console.Write("Enter a Number: ");
            //int X = int.Parse(Console.ReadLine());

            //if (X >= 0)
            //{
            //    Console.WriteLine("positive");

            //}
            //else
            //{
            //    Console.WriteLine("negative");
            //}
            #endregion

            //===========================
            #region Q3
            /*Write a program that takes 3 integers from the user then prints the max element and the min element.*/

            //Console.WriteLine("Enter three integers separated by comma: ");
            //string[] input = Console.ReadLine().Split(',');

            //int X = int.Parse(input[0]);
            //int Y = int.Parse(input[1]);
            //int Z = int.Parse(input[2]);

            //if (X > Y && X > Z)
            //{
            //    if (Y > Z)
            //    {
            //        Console.WriteLine($"Max Element = {X}");
            //        Console.WriteLine($"Min Element = {Z}");

            //    }
            //    else
            //    {
            //        Console.WriteLine($"Max Element = {X}");
            //        Console.WriteLine($"Min Element = {Y}");
            //    }
            //}
            //else if (Y > X && Y > Z)
            //{
            //    if (X > Z)
            //    {
            //        Console.WriteLine($"Max Element = {Y}");
            //        Console.WriteLine($"Min Element = {Z}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Max Element = {Y}");
            //        Console.WriteLine($"Min Element = {X}");
            //    }
            //}
            //else if (Z > X && Z > Y)
            //{
            //    if (X > Y)
            //    {
            //        Console.WriteLine($"Max Element = {Z}");
            //        Console.WriteLine($"Min Element = {Y}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Max Element = {Z}");
            //        Console.WriteLine($"Min Element = {X}");
            //    }
            //}



            #endregion

            //===========================
            #region Q4
            /* 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.*/

            //Console.Write("Enter a Number: ");
            //int X = int.Parse(Console.ReadLine());

            //if (X % 2 == 0)
            //{
            //    Console.WriteLine("Even Number");

            //}
            //else
            //{
            //    Console.WriteLine("Odd Number");
            //}
            #endregion

            //===========================
            #region Q5
            /* Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).*/


            //Console.Write("Enter a Char: ");
            //Char X = char.Parse(Console.ReadLine());

            //if (X == 'a' ||  X == 'e' || X == 'o' || X == 'u' || X == 'i')
            //{
            //    Console.WriteLine("Vowel");

            //}
            //else
            //{
            //    Console.WriteLine("Constant");
            //}

            #endregion

            //===========================
            #region Q6
            /* 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.*/

            //Console.Write("Enter a Number: ");
            //int X = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= X; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            //===========================
            #region Q7
            /*Write a program that allows the user to insert an integer then print a multiplication table up to 12.*/

            //Console.Write("Enter a Number: ");
            //int X = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i * X);
            //}
            #endregion

            //===========================
            #region Q8
            /*Write a program that allows to user to insert number then print all even numbers between 1 to this number */

            //Console.Write("Enter a Number: ");
            //int X = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= X; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            #endregion

            //===========================
            #region Q9
            /*Write a program that takes two integers then prints the power.*/


            //Console.Write("Enter a 1st Number: ");
            //double X = double.Parse(Console.ReadLine());
            //Console.Write("Enter a 2nd Number: ");
            //double Y = double.Parse(Console.ReadLine());
            //double P = Math.Pow(X, Y);

            //Console.WriteLine(P);

            #endregion

            //===========================
            #region Q10
            /*10- Write a program to enter marks of five subjects and calculate total, average and percentage.*/

            //Console.Write("Enter marks for five subjects: ");
            //string[] input = Console.ReadLine().Split();


            //int total = 0;
            //double avg, perc;

            //for (int i = 0; i < 5; i++)
            //{
            //    total += int.Parse(input[i]);
            //}
            //avg = total / 5.0;
            //perc = (total / 500.0) * 100;

            //Console.WriteLine($"total: {total} ");
            //Console.WriteLine($"avg: {avg} ");
            //Console.WriteLine($"perc: {perc} ");






            #endregion

            //===========================
            #region Q11
            /*Write a program to input the month number and print the number of days in that month.*/

            //Console.Write("Enter Number Of Month: ");
            //string input = (Console.ReadLine());

            //Console.WriteLine(
            //    input switch
            //    {
            //        "1" or "3" or "5" or "7" or "8" or "10" or "12" => "31",
            //        "4" or "6" or "9" or "11" or "5" => "30",
            //        "2" => "28",
            //        _ => "Invalid Month"
            //    }
            //    );
            #endregion

            //===========================
            #region Q12
            /*Write a program to create a Simple Calculator.*/

            //Console.Write("Enter 1stNumber: ");
            //int Num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter Sign: ");
            //string sign = Console.ReadLine();

            //Console.Write("Enter 2ndNumber: ");
            //int Num2 = int.Parse(Console.ReadLine());

            //if (sign == "+")
            //{
            //    Console.WriteLine(Num1 + Num2);
            //}
            //else if (sign == "-")
            //{
            //    Console.WriteLine(Num1 - Num2);
            //}
            //else if (sign == "*")
            //{
            //    Console.WriteLine(Num1 * Num2);
            //}
            //else if(sign == "/")
            //{
            //    Console.WriteLine(Num1 / Num2);
            //}
            #endregion

            //===========================
            #region Q13
            /*13- Write a program to allow the user to enter a string and print the REVERSE of it.*/

            //Console.Write("Enter string: ");
            //string s = Console.ReadLine();

            //string reversed = "";

            //for (int i = s.Length - 1; i >= 0; i--)
            //{
            //    reversed += s[i];
            //}
            //Console.WriteLine($"Reversed string: {reversed}");
            #endregion

            //===========================
            #region Q14
            /*14- Write a program to allow the user to enter int and print the REVERSED of it.*/

            //Console.Write("Enter an Intger: ");
            //int Num = int.Parse(Console.ReadLine());
            //int Revers = 0;

            //while(Num != 0)
            //{
            //    int digit = Num % 10;
            //    Revers = Revers * 10 + digit;
            //    Num = Num / 10;
            //}
            //Console.WriteLine($"Reversed string: {Revers}");

            #endregion

            //===========================
            #region Q15
            /*15- Write a program in C# Sharp to find prime numbers within a range of numbers.*/

            //Console.Write("Enter an 1st Number: ");
            //int Num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter an 2nd Number: ");
            //int Num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Prime Number between {Num1} and {Num2}");

            //for (int i = Num1; i <= Num2; i++)
            //{
            //    if (i <= 1)
            //        continue;

            //    bool prime = true;
            //    for (int j = 2; j <= Math.Sqrt(i); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            prime = false;
            //            break;
            //        }
            //    }
            //    if (prime)
            //    {
            //        Console.WriteLine(i + " ");
            //    }
            //}

            #endregion

            //===========================
            #region Q16
            /*16- . Write a program in C# Sharp to convert a decimal number into binary without using an array.*/

            //Console.Write("Enter A number: ");
            //int Num = int.Parse(Console.ReadLine());

            //string binary = "";


            //if (Num == 0)
            //    binary = "0";
            //else
            //{
            //    while (Num > 0)
            //    {
            //        int rem = Num % 2;
            //        binary = rem + binary;
            //        Num = Num / 2;
            //    }
            //}
            //Console.WriteLine($"The Binary  is {binary}");


            #endregion

            //===========================
            #region Q17
            /*17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.*/


            //Console.WriteLine("Enter point 1 (x1,y1)");
            //string[] point1 = Console.ReadLine().Split(',');
            //int x1 = int.Parse( point1[0]);
            //int y1 = int.Parse(point1[1]);

            //Console.WriteLine("Enter point 2 (x2,y2)");
            //string[] point2 = Console.ReadLine().Split(',');
            //int x2 = int.Parse(point2[0]);
            //int y2 = int.Parse(point2[1]);

            //Console.WriteLine("Enter point 3(x3,y3)");
            //string[] point3 = Console.ReadLine().Split(',');
            //int x3 = int.Parse(point3[0]);
            //int y3 = int.Parse(point3[1]);


            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else 
            //{
            //    Console.WriteLine("The points donot lie on a single straight line.");
            //}



            #endregion
            //===========================
            #region Q18
            /*18- - Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
              - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
              - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
              - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
              - If the worker takes more than 5 hours, they are required to leave the company. 
                To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            */

            //Console.WriteLine("Enter Time to complete tasks in Hours");
            //double T = double.Parse(Console.ReadLine());

            //if (T >= 2 && T < 3) 
            //{
            //    Console.WriteLine("highly efficient");
            //}
            //else if(T >= 3 && T < 4)
            //{
            //    Console.WriteLine("needs to increase their speed");
            //}
            //else if (T >= 4 && T < 5)
            //{
            //    Console.WriteLine("requires training to enhance their speed");
            //}
            //else if (T > 5)
            //{
            //    Console.WriteLine("required to leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}


            #endregion


        }
    }
}
