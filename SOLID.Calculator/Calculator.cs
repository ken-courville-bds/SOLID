using SOLID.Math.Logging;
using System;

namespace SOLID.Math
{
    public class Calculator: ICalculator
    {
        private double result;
        private readonly ILog logger;

        public Calculator(ILog logger)
        {
            this.logger = logger;
        }

        public ICalculator Input(double initialValue)
        {
            result = initialValue;
            logger.Append("Initial value: {0}", initialValue);
            return this;
        }

        public ICalculator Input(string @operator, double operand)
        {
            if (@operator == null)
            {
                throw new ArgumentNullException(nameof(@operator));
            }

            logger.Append("Applying operation {0}. Value={1}", @operator, operand);
            switch (@operator)
            {
                case "+":
                    result += operand;
                    break;
                case "-":
                    result -= operand;
                    break;
                case "*":
                    result *= operand;
                    break;
                case "/":
                    result /= operand;
                    break;
                default:
                    throw new NotSupportedException($"Operator not supported: {@operator}");
            }
            logger.Append("Applying operation {0}. Value={1}", @operator, operand);
            return this;
        }

        public double Result()
        {
            return result;
        }
    }
}
