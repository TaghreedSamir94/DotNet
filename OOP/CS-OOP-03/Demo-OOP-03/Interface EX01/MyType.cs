using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_03.Interface_EX01
{
    internal class MyType : IMyType /*<< mean  inmplement Interface*/
    {
        public int Age { get; set ; } // in class called Auto Property but in Interface called Signiture of Proerty

        public void MyFun()
        {
            Console.WriteLine("Hello World :) ");
        }
    }
}
