using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Assignment_01
{
    internal struct Person
    {
        public String Name { get; set; }
        public int Age { get; set; }

        public Person(String name, int age)
        {
            Name = name; 
            Age = age;
        }

        public void DisplayOldest(Person P2, Person P3)
        {
            if (Age > P2.Age)
            {
                if (Age > P3.Age)
                {
                    Console.WriteLine($"{Name} is oldest person with Age: {Age}");
                }
                else
                {
                    Console.WriteLine($"{P3.Name} is oldest person with Age: {P3.Age}");
                }

            }
            else
            {
                if (P2.Age > P3.Age)
                {
                    Console.WriteLine($"{P2.Name} is oldest person with Age: {P2.Age}");
                }
                else
                {
                    Console.WriteLine($"{P3.Name} is oldest person with Age: {P3.Age}");
                }

            }
        }
    }
}
