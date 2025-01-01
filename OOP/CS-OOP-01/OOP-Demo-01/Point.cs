using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Demo_01
{
    internal struct Point
    {
       public int X;  // 4 bytes in stack
       public int Y;  // 4 bytes 

        //Attribute feild
        // Methods
        //Event
        //Property

        //Constructor: Special type from method
        //            1. Named Like Struct
        //            2. Has no return Type


        // CLR: will generate Paramterless Constructor
        // this constructor will intialized the Attributes with the dfault value

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"({X},{Y})");
        }

    }
}
