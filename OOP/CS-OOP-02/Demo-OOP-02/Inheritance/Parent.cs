using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_02.Inheritance
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            this.X = x;
            this.Y = y;
            
        }

        public override string ToString()
        {
           return $"X:{X}, Y:{Y}";
        }

        public void Fun01()
        {
            Console.WriteLine("I'm Parent");
        }

        public void Fun02()
        {
            Console.WriteLine($"X:{X}, Y:{Y}");
        }
    }
}
