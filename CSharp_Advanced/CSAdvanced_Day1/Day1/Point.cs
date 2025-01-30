using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y; 
        }
        public override string ToString() 
        { 
            return $"({X}, {Y})";
        }

        public int CompareTo(Point? other)
        {
            if (other is not null)
            {
                if (X == other.X) return Y.CompareTo(other.Y);
                return X.CompareTo(other.X);

            }
            return 1;
        }

        //public int CompareTo(object? obj)
        //{
        //    Point point =(Point)obj;
        //    if(X == point.X ) return Y.CompareTo(point.Y);
        //    return X.CompareTo(point.X);
        //}

        //public int CompareTo(object? obj)
        //{
        //    if (obj is not null)
        //    {
        //        Point point = (Point)obj;
        //        if (X == point.X) return Y.CompareTo(point.Y);
        //        return X.CompareTo(point.X);

        //    }
        //    return 1;

        //}

        //=====1. Is Conditional Operature --- check type of object -- work in Struct / Class
        //public int CompareTo(object? obj)
        //{
        //    if (obj is not null)
        //    {
        //        if (obj is Point point)
        //        {
        //            if (X == point.X) return Y.CompareTo(point.Y);
        //            return X.CompareTo(point.X);
        //        }
        //        //Point point = (Point)obj;


        //    }
        //    return 1;

        //}


        //=====2. as Casting Operature  -- work in  Class  // work with nullbaleType
        //public int CompareTo(object? obj)
        //{
        //    Point p = obj as Point;
        //    if(p is not null)
        //    {

        //        if (X == p.X) return Y.CompareTo(p.Y);
        //        return X.CompareTo(p.X);
        //    }
        //    return 1;

        //}
    }
}
