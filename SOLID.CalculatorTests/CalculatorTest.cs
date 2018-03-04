using FakeItEasy;
using SOLID.Math;
using SOLID.Math.Logging;
using System;
using Xunit;

namespace SOLID.CalculatorTests
{
    public class CalculatorTest : IDisposable
    {
        private readonly ILog fakeLogger;
        private readonly ICalculator sut;

        public CalculatorTest()
        {
            fakeLogger = A.Fake<ILog>();
            sut = new Calculator(fakeLogger);
        }

        public void Dispose()
        {
            EnsureLogged();
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

        private void EnsureLogged()
        {
            A.CallTo(() => fakeLogger.Append(A<string>.Ignored, A<object[]>.Ignored)).MustHaveHappened();
        }
    }
}
