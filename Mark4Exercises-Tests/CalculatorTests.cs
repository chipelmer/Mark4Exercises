using System;
using Xunit;
using Mark4Exercises;

namespace Mark4Exercises_Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(5, 7, 12)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, -2)]
        [InlineData(-2, -2, -4)]
        [InlineData(-5, -7, -12)]
        [InlineData(-1, 1, 0)]
        public void Add(int addend1, int addend2, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actualResult = calculator.Add(addend1, addend2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(7, 2, 5)]
        [InlineData(5, 7, -2)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 0)]
        [InlineData(-7, -2, -5)]
        [InlineData(-5, -7, 2)]
        [InlineData(-1, 1, -2)]
        public void Subtract(int minuend, int subtrahend, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actualResult = calculator.Subtract(minuend, subtrahend);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(7, 2, 14)]
        [InlineData(5, 7, 35)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 1)]
        [InlineData(-7, 2, -14)]
        [InlineData(-5, 7, -35)]
        [InlineData(-1, 1, -1)]
        public void Multiply(int factor1, int factor2, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actualResult = calculator.Multiply(factor1, factor2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(7, 2, 3.5)]
        [InlineData(5, 7, 0.71428571)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, 1)]
        [InlineData(-7, 2, -3.5)]
        [InlineData(10, 3, 3.33333333)]
        [InlineData(10, 4, 2.5)]
        public void Divide(int dividend, int divisor, double expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            double actualResult = calculator.Divide(dividend, divisor);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 8), Math.Round(actualResult, 8));
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(7, 2, 49)]
        [InlineData(5, 7, 78125)]
        [InlineData(0, 0, 1)]
        [InlineData(-1, -1, -1)]
        [InlineData(-7, 2, 49)]
        [InlineData(10, -3, 0.001)]
        [InlineData(4, -3, 0.015625)]
        [InlineData(4, -2, 0.0625)]
        public void Power(int baseNumber, int exponent, double expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();
            
            // Act
            double actualResult = calculator.Power(baseNumber, exponent);

            // Assert
            Assert.Equal(Math.Round(expectedResult, 8), Math.Round(actualResult, 8));
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(6, 720)]
        [InlineData(-1, 1)]
        [InlineData(-2, 1)]
        public void Factorial(int number, int expectedResult)
        {
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            int actualResult = calculator.Factorial(number);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
