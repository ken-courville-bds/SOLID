using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Math.Computations
{
    public class SubstractComputation : IComputation
    {
        public string Operator => "-";

        public double Invoke(double result, double operand)
        {
            return result - operand;
        }
    }
}
