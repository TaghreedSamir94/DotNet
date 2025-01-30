using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay_1
{
    internal class Range<T> where T : IComparable<T>
    {
        public T MaxValue { get; set; }
        public T MinValue { get; set; }
        public Range(T min, T max)
        {
            MinValue = min;
            MaxValue = max;
        }

        public override string ToString()
        {
            return $"Range:({MinValue},{MaxValue})";
        }

        public bool IsInRange(T Value)
        {
            if (Value.CompareTo(MinValue) >= 0 && Value.CompareTo(MaxValue) <= 0)
            {
                return true;
            }
            return false;
        }

        public dynamic Length()
        {
            return (dynamic)MaxValue - (dynamic)MinValue;
        }


    }

}
