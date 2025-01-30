using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay_1
{
    internal class Helper
    {
        public static void Swap<T>(ref T X, ref T Y)
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public static void PrintArray<T>(T[]Arr)
        {
            foreach(T i in Arr)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }


    }
}
