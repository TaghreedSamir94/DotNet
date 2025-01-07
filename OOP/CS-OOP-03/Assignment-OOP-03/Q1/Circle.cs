using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_03.Q1
{
    internal class Circle : ICircle
    {
        public double Radious { get;  set; }

        public double Area => Math.PI * Radious * Radious;

        public Circle(double radious)
        {
            Radious = radious;

        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radious: {Radious} its Area is: {Area:F2}");
        }
    }
}
