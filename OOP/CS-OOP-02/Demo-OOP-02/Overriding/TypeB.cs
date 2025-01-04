using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Demo_OOP_02.Overriding
//{
//    internal class TypeB : TypeA
//    {
//        public int B { get; set; }


//        //Apply Overrider or Hide
//        //1. Apply Override using New Keyword ( when not write any keyword = new)
//        //2. Apply Override using Override Keyword 

//        //Static Binding
//        //Compiler Will Bind Function Based on ReferenceType not objectType
//        //At Compilation Time
//        public new void Fun01()   // Using New KeyWord
//        {
//            Console.WriteLine("Func1 From Type B");
//        }

//        // to use Override Keyword
//        //  func in parent must be not Private and Virtual

//        //Dynamic Binding
//        //CLR Will Bind The Function based on Object not ReferenceType
//        public override void Fun02() // using Override KeyWord
//        {
//            Console.WriteLine($"A:{A}, B:{B}");
//        }
//    }
//}
