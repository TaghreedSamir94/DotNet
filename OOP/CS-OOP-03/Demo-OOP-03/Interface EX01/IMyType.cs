using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP_03.Interface_EX01
{
    internal interface IMyType
    {
        //Can Write inside Interface:
        //1. Signiture of Proprties
        //2. Signiture of Methods [Names, ReturnType, Parameter] without Body
        //3. Fully implemented Methods [with Body]
        //====================

        //1. Signiture of Proprties:
         int Age { get; set; }

        //2. Signiture of Methods:
        void MyFun();

        //3. Fully implemented Methods :
        void Print()
        {
            Console.WriteLine(" ");
        }

    }
}
