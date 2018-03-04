using SOLID.Math.Computations;
using SOLID.Math.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SOLID.Math
{
    public class Calculator : ICalculator
    {
        private double result;
        private readonly ILogService logger;
        private readonly IDictionary<string, IComputation> computations;

        public Calculator(LogServiceFactoryDelegate logServiceFactory, IEnumerable<IComputation> computations)
        {
            logger = logServiceFactory(typeof(Calculator).Name);
            this.computations = computations.ToDictionary(d => d.Operator);
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
            if (!computations.ContainsKey(@operator))
            {
                throw new NotSupportedException($"Operator not supported: {@operator}");
            }
            result = computations[@operator].Invoke(result, operand);
            logger.Append("Applied operation {0}. Value={1}", @operator, operand);
            return this;
        }

        public double Result()
        {
            return result;
        }
    }
}
