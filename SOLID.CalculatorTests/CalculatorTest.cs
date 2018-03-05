using FakeItEasy;
using SOLID.Math;
using SOLID.Math.Logging;
using System;
using Xunit;
using FluentAssertions;
using SOLID.Math.Computations;
using System.Collections.Generic;

namespace SOLID.CalculatorTests
{
    public class CalculatorTest : IDisposable
    {
        private readonly ILogService fakeLogger;
        private readonly ICalculator sut;

        public CalculatorTest()
        {
            fakeLogger = A.Fake<ILogService>();
            var computations = new List<IComputation>()
            {
                new AddComputation(),
                new DivideComputation(),
                new SubstractComputation(),
                new MultiplyComputation()
            };
            sut = new Calculator(name => fakeLogger, computations);
        }

        public void Dispose()
        {
            A.CallTo(() => fakeLogger.Append(A<LogEntry>.Ignored))
                .MustHaveHappened();
        }

        [Fact]
        public void Add()
        {
            sut
                .Input(1)
                .Input("+", 1)
                .Result()
                .Should().Be(2);
        }

        [Fact]
        public void Substract()
        {
            sut
                .Input(1)
                .Input("-", 1)
                .Result()
                .Should().Be(0);
        }

        [Fact]
        public void Multiply()
        {
            sut
                .Input(1)
                .Input("*", 2)
                .Result()
                .Should().Be(2);
        }

        [Fact]
        public void Divide()
        {
            sut
                .Input(2)
                .Input("/", 2)
                .Result()
                .Should().Be(1);
        }

        [Fact]
        public void Chaining()
        {
            sut
                .Input(2)
                .Input("+", 10)
                .Input("-", 10)
                .Input("*", 2)
                .Input("/", 2)
                .Result()
                .Should().Be(2);
        }
    }
}
