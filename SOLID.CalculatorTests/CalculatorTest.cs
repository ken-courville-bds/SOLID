using SOLID.Math;
using System;
using Xunit;

namespace SOLID.CalculatorTests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add()
        {
            var actual = new Calculator(1)
                .Input("+", 1)
                .Result();
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Substract()
        {
            var actual = new Calculator(1)
                .Input("-", 1)
                .Result();
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Multiply()
        {
            var actual = new Calculator(1)
                .Input("*", 2)
                .Result();
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Divide()
        {
            var actual = new Calculator(2)
                .Input("/", 2)
                .Result();
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Chaining()
        {
            var actual = new Calculator(2)
                .Input("+", 10)
                .Input("-", 10)
                .Input("*", 2)
                .Input("/", 2)
                .Result();
            Assert.Equal(2, actual);
        }

        [Fact]
        public void VerifyLogger()
        {
            throw new NotImplementedException("Logging cannot be verified! Abstract it!");
        }
    }
}
