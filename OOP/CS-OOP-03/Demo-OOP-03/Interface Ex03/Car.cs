using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_03.Interface_Ex03
{
    internal class Car : IMoveable
    {
        public int Speed { get ; set; }

        public void Backward()
        {
            Console.WriteLine("car Moveable Backward");
        }

        public void Forward()
        {
            Console.WriteLine("car Moveable Forward");
        }

        public void Left()
        {
            Console.WriteLine("car Moveable Left");
        }

        public void Right()
        {
            Console.WriteLine("car Moveable Right");
        }
    }
}
