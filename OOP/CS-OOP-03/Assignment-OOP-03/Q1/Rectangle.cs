using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_03.Q1
{
    internal class Rectangle : IRectangle
    {
        public double Width {  get; set; }

        public double Height {  get; set; }

        public double Area => Width * Height ;

        public Rectangle(double H, double W)
        {
            Width = W; 
            Height = H; 
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle With Height {Height} and Width {Width} its Area is: {Area:F2}");
        }
    }
}
