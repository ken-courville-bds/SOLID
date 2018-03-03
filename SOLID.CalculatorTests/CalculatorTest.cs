using SOLID.Math;
using System;
using Xunit;

namespace SOLID.CalculatorTests
{
    public class CalculatorTest
    {
        private readonly ICalculator sut;

        public CalculatorTest()
        {
            sut = new Calculator();
        }
        [Fact]
        public void Add()
        {
            var actual = sut
                .Input(1)
                .Input("+", 1)
                .Result();
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Substract()
        {
            var actual = sut
                .Input(1)
                .Input("-", 1)
                .Result();
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Multiply()
        {
            var actual = sut
                .Input(1)
                .Input("*", 2)
                .Result();
            Assert.Equal(2, actual);
        }

        [Fact]
        public void Divide()
        {
            var actual = sut
                .Input(2)
                .Input("/", 2)
                .Result();
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Chaining()
        {
            var actual = sut
                .Input(2)
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
