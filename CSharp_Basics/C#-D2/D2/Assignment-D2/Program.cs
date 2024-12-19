using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_D2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ////1-Write a program that allows the user to enter a number then print it.

            //int Num;
            //Console.WriteLine("Enter A Number");
            //bool F =  int.TryParse(Console.ReadLine(), out Num);
            //Console.WriteLine("Number You Enterd is: " + Num);

            #endregion

            //===================
            #region Q2
            ////program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 

            //int Num;
            //Console.WriteLine("Enter a Word");
            //bool F =  int.TryParse(Console.ReadLine(), out Num);
            //Console.WriteLine(Num);

            //// when used parse there nothing print and catch error 
            //// but when using try pasrs the output was 0 

            #endregion

            //===================
            #region Q3
            ////program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen

            //float Num1 = 5.6f , Num2 = 8.689f ;
            //float Sum = Num1 + Num2;
            //float Sub = Num1 - Num2;
            //float mul = Num1 * Num2;
            //float dev = Num1 / Num2;
            //float mod = Num1 % Num2;
            //Console.WriteLine("Summation is : " + Sum);
            //Console.WriteLine("Subtraction is : " + Sub);
            //Console.WriteLine("Multipication is : " + mul);
            //Console.WriteLine("Division is : " + dev);
            //Console.WriteLine("Modelus is : " + mod);

            //// some percision erors are accured when using float
            #endregion

            //===================
            #region Q4
            //// 4 - Write C# program that Extract a substring from a given string.

            //Console.WriteLine("Write A string");
            //String OrgString = Console.ReadLine();
            //Console.WriteLine("Write A StartIndex");
            //int Start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Write Length of Sbstring");
            //int len = int.Parse(Console.ReadLine());

            //string SubString = OrgString.Substring(Start, len);
            //Console.WriteLine("Your SubString is: " + SubString);

            #endregion
            //===================
            #region Q5
            ////program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int X = 5;
            //int Y = X;
            //X = 8;
            //Console.WriteLine(X);
            //Console.WriteLine(Y);

            ////Value type like int are independent and store thei data directly to memmory
            ////and assigning one value type to another creates a separate copy
            //// when modify one value type variable does not affect

            #endregion

            //===================
            #region Q6
            ////program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            ////1st step create class Student
            //Student student1 = new Student();
            //student1.Name = "ABc";
            //Student student2 = student1;
            //student2.Name = "Xyz";

            //Console.WriteLine(student1.Name); //Xyz
            //Console.WriteLine(student2.Name); //Xyz

            ////both Stud1 and Stud2 are refrence type so they  refer to  same object in memory
            ////when modify on of them, anathor object affected because they point to the same memory location

            #endregion

            //===================
            #region Q7
            ////7 - Write C# program that take two string variables and print them as one variable 

            //Console.WriteLine("Enter 1st Word");
            //string word1 =  Console.ReadLine();
            //Console.WriteLine("Enter 2nd Word");
            //string word2 = Console.ReadLine();
            //string MixString = word1 + " " + word2;
            //Console.WriteLine(MixString);


            #endregion

            //===================
            #region Q8
            ///*
            //8 - Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            //The formula for simple interest is
            //Interest = (principal * rate * time) / 100.*/

            //Console.WriteLine("Enter value of principal");
            //int principal = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter value of rate");
            //int rate = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter value of time");
            //int time = int.Parse(Console.ReadLine());
            //int Interest = (principal * rate * time) / 100;

            //Console.WriteLine("Simple Interest is : " + Interest);


            #endregion

            //===================
            #region Q9
            ///*9-Write a program that calculates the Body Mass Index (BMI) 
            // * given a person's weight in kilograms and height in meters. 
            // * The formula for BMI is BMI = (Weight)/(Height*Height)*/

            //Console.WriteLine("Enter you weight in KG");
            //float Weight = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your Height in meter");
            //float Height = float.Parse(Console.ReadLine());

            //float BMI = (Weight) / (Height * Height);

            //Console.WriteLine("Your BMI is : " + BMI);

            #endregion

            //===================
            #region Q10
            /*10-Write a program that uses the ternary operator to check if 
             * the temperature is too hot, too cold, or just good. 
             * Assign the result in a variable then display the result. 
             * Assume that below 10 degrees is "Just Cold", 
             * above 30 degrees is "Just Hot", and anything else is "Just Good".*/

            //Console.WriteLine("Enter temperature");
            //float temp = float.Parse(Console.ReadLine());


            //string flag = temp > 30 ? "Just Hot" : temp < 10 ? "Just Cold" : "Just Good";

            //Console.WriteLine("Temprature is : " + flag);

            #endregion
            //===================
            #region Q11
            /*11-Write a program that takes the date from the user and displays
             * it in various formats using string interpolation.
             * Ex :
             * Today’s date : 20 , 11 , 2001
               Today's date : 20 / 11 / 2001
               Today's date : 20 – 11 – 2001
            */

            //Console.WriteLine("Enter Date in formt(dd/mm/yyyy)");
            //DateTime date;
            //string input = Console.ReadLine();
            //bool Flag = DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date);
            //Console.WriteLine($"date (comma separated): {date:dd , MM , yyyy}");
            //Console.WriteLine($"date (slash separated): {date:dd / MM / yyyy}");
            //Console.WriteLine($"date (dash separated): {date:dd - MM - yyyy}");
            


            #endregion
            //===================
            #region Q12

            //answer is c --The event is on 06/14/2024

            #endregion

            //===================
            #region Q13

            //answer is f)	A value 1 will be assigned to d.
            #endregion

            //===================
            #region Q14
            // answer is d)	6 1
            #endregion

            //===================
            #region Q15
            //answer is d)	7 7
            #endregion
        }
    }
}
