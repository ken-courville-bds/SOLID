using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Math.Computations
{
    public interface IComputation
    {
        string Operator { get; }

        double Invoke(double result, double operand);
    }
}
