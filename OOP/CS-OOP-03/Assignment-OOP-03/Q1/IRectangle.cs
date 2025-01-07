using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_03.Q1
{
    internal interface IRectangle: IShape
    {
        double Width { get; }
        double Height { get; }
    }
}
