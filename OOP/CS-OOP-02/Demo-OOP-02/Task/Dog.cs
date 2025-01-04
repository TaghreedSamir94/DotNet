using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Animal;

namespace Demo_OOP_02.Task
{
    internal class Dog : AnimalClass
    {
        public void Fun01()
        {
            Console.WriteLine($"The animal's name is {Name}"); //✔
        }

        public void Fun02()
        {
            Console.WriteLine($"The animal's color is {Color}");  //✔
        }
        public void Fun03()
        {
            Console.WriteLine($"The animal's leg is {NumOgLegs}"); //❌❌
        }
    }
}
