using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal static class Helper/*<T>*/   //define generic based on Class
    {
        #region Using Non Generic Swap Method
        //public static void Swap( ref int X,   ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void Swap(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void Swap(ref Point X, ref Point Y)
        //{
        //    Point Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion

        #region Using Generic Swap Method

        public static void Swap<T>(ref T X, ref T Y)  //define generic based on Func
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }
        #endregion

        #region Using Non Generic LinearSearch Method
        //public static int LinearSearch(int[] Arr, int Value)
        //{
        //    if (Arr?.Length > 0)
        //    {
        //        for (int i = 0; i < Arr.Length; i++)
        //        {
        //            if (Arr[i] == Value)
        //            {
        //                return i;
        //            }
        //        }
        //    }
        //    return -1;
        //}
        #endregion

        #region Using Generic LinearSearch Method
        public static int LinearSearch<T>(T[] Arr, T Value)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (Arr[i].Equals(Value))   // not using == because struct dont have it 
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        #endregion

        #region Using Generic LinearSearch Method with IequalityCompareror
        public static int LinearSearch<T>(T[] Arr, T Value, IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    if (equalityComparer.Equals(Arr[i], Value))   // not using == because struct dont have it 
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        #endregion

        #region  Using non Generic BubbleSort Method

        //public static void BubbleSort(int[] Arr)
        //{
        //    if(Arr?.Length > 0)
        //    {
        //        for(int i = 0;i < Arr.Length; i++)
        //        {
        //            for(int j = 0; j < Arr.Length - i -1; j++)
        //            {
        //                if (Arr[j] > Arr[j+ 1])
        //                {
        //                    Swap(ref Arr[j], ref Arr[j+1]);
        //                }
        //            }
        //        }
        //    }
        //}

        #endregion

        #region Using  Generic BubbleSort Method

        public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (Arr[j].CompareTo(Arr[j + 1]) > 0)
                        {
                            Swap(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

        #endregion

        #region Using  Generic BubbleSort Method with Icomparer

        public static void BubbleSort<T>(T[] Arr, IComparer<T> comparable) where T : IComparable<T>
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = 0; j < Arr.Length - i - 1; j++)
                    {
                        if (comparable.Compare(Arr[j], Arr[j+1]) > 0)
                        {
                            Swap(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

        #endregion


        public static void PrintArr<T>(T[] Arr)
        {
            foreach(T i in Arr)
            {
                Console.WriteLine($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
