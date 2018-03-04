using System;

namespace SOLID.Math.Computations
{
    public class MultiplyComputation : IComputation
    {
        public string Operator => "*";

        public double Invoke(double result, double operand)
        {
            return result * operand;
        }
    }
}
