using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_03.Interface_Ex03
{
    internal class AirPlane : IFlyable, IMoveable
    {
       int IMoveable.Speed { get ; set ; }

       int IFlyable.Speed { get; set; }

        void IMoveable.Backward()
        {
            Console.WriteLine("AirPlane Moveable Backward");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("AirPlane Moveable Forward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("AirPlane Moveable Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("AirPlane Moveable Right");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("AirPlane IFlyable Backward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlane IFlyable Forward");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("AirPlane IFlyable Left");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("AirPlane IFlyable Right");
        }
    }
}
