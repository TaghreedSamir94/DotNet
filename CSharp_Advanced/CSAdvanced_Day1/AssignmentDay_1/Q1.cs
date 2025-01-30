using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay_1
{
    internal class Q1
    {
        public static void OptimizedBubbleSort<T>(T[] Arr) where T : IComparable<T>
        {
            bool swapped;
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < Arr.Length - i - 1; j++)
                {
                    if(Arr[j].CompareTo(Arr[j + 1]) > 0)
                    {
                        Helper.Swap(ref Arr[j], ref Arr[j + 1]);
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }


     
    }
}
