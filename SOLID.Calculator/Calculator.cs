using System;

namespace SOLID.Math
{
    public class Calculator
    {
        private double result;

        public Calculator(double value)
        {
            result = value;
        }

        public Calculator Input(string op, double value)
        {
            switch (op)
            {
                case "+":
                    result += value;
                    break;
                case "-":
                    result -= value;
                    break;
                case "*":
                    result *= value;
                    break;
                case "/":
                    result /= value;
                    break;
                default:
                    throw new NotSupportedException($"Operation not supported: {op}");
            }
            return this;
        }

        public double Result()
        {
            return result;
        }
    }
}
