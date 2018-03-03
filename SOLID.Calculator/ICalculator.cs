using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Math
{
    public interface ICalculator
    {
        /// <summary>
        /// Supply the initial value. 
        /// 
        /// NOTE: Subsequent calls to this will ovewrite the 
        /// current result.
        /// </summary>
        /// <param name="initialValue"></param>
        /// <returns></returns>
        ICalculator Input(double initialValue);


        /// <summary>
        /// Apply an operation
        /// </summary>
        /// <param name="operator"></param>
        /// <param name="operand"></param>
        /// <returns></returns>
        ICalculator Input(string @operator, double operand);

        /// <summary>
        /// Retrieve the current, computed value
        /// </summary>
        /// <returns></returns>
        double Result();
    }
}
