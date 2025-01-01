using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Assignment_01
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceBetween(Point P2)
        {
            return Math.Sqrt(Math.Pow(X - P2.X, 2) + Math.Pow(Y - P2.Y, 2));
        }
    }
}
