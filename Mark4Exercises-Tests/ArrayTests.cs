using System;
using Xunit;
using Mark4Exercises;

namespace Mark4Exercises_Tests
{
    public class ArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, 3)]
        [InlineData(new int[] { 5, 10, 15 }, 30)]
        [InlineData(new int[] { -1, -1, -1 }, -3)]
        [InlineData(new int[] { -5, -10, -15 }, -30)]
        [InlineData(new int[] { 7, -2, 5 }, 10)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void Sum(int[] numbers, int expectedSum)
        {
            // Arrange
            ArraySolver arraySolver = new ArraySolver();

            // Act
            int actualSum = arraySolver.Sum(numbers);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, 0)]
        [InlineData(new int[] { 5, 10, 15 }, 0)]
        [InlineData(new int[] { -1, -1, -1 }, -3)]
        [InlineData(new int[] { -5, -10, -15 }, -30)]
        [InlineData(new int[] { 7, -2, 5 }, -2)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void SumNegativeNumbers(int[] numbers, int expectedSum)
        {
            // Arrange
            ArraySolver arraySolver = new ArraySolver();

            // Act
            int actualSum = arraySolver.SumNegativeNumbers(numbers);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, 1)]
        [InlineData(new int[] { 5, 10, 15 }, 10)]
        [InlineData(new int[] { -1, -1, -1 }, -1)]
        [InlineData(new int[] { -5, -10, -15 }, -10)]
        [InlineData(new int[] { 7, -2, 5 }, 3.33333333)]
        [InlineData(new int[] { 2, 3, 4, 5 }, 3.5)]
        [InlineData(new int[] { 15, 20, 71, 155 }, 65.25)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void Average(int[] numbers, double expectedAverage)
        {
            // Arrange
            ArraySolver arraySolver = new ArraySolver();

            // Act
            double actualAverage = arraySolver.Average(numbers);

            // Assert
            Assert.Equal(Math.Round(expectedAverage, 8), Math.Round(actualAverage, 8));
        }

        [Theory]
        [InlineData(new bool[] { false, false, false }, false)]
        [InlineData(new bool[] { false, false, true }, true)]
        [InlineData(new bool[] { true, false, false }, true)]
        [InlineData(new bool[] { true, true, true }, true)]
        [InlineData(new bool[] { false }, false)]
        [InlineData(new bool[] { true }, true)]
        [InlineData(new bool[] { }, false)]
        [InlineData(null, false)]
        public void ContainsTrue(bool[] values, bool expectedResult)
        {
            // Arrange
            ArraySolver arraySolver = new ArraySolver();

            // Act
            bool actualResult = arraySolver.ContainsTrue(values);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, false)]
        [InlineData(new int[] { 2, 1, 1 }, true)]
        [InlineData(new int[] { 1, 1, 2 }, true)]
        [InlineData(new int[] { 5, 10, 15 }, true)]
        [InlineData(new int[] { -1, -1, -1 }, false)]
        [InlineData(new int[] { -5, -10, -15 }, true)]
        [InlineData(new int[] { 7, -2, 5 }, true)]
        [InlineData(new int[] { 0, 0 }, true)]
        [InlineData(new int[] { }, false)]
        [InlineData(null, false)]
        public void ContainsEven(int[] numbers, bool expectedResult)
        {
            // Arrange
            ArraySolver arraySolver = new ArraySolver();

            // Act
            bool actualResult = arraySolver.ContainsEven(numbers);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(0, new int[] { })]
        [InlineData(1, new int[] { })]
        [InlineData(2, new int[] { 2 })]
        [InlineData(3, new int[] { 2 })]
        [InlineData(4, new int[] { 2, 4 })]
        [InlineData(5, new int[] { 2, 4 })]
        [InlineData(6, new int[] { 2, 4, 6 })]
        [InlineData(20, new int[] { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 })]
        [InlineData(-1, new int[] { })]
        [InlineData(-2, new int[] { })]
        public void GetPositiveEvenNumbers(int maxNumber, int[] expectedResult)
        {
            // Arrange
            ArraySolver arraySolver = new ArraySolver();

            // Act
            int[] actualResult = arraySolver.GetPositiveEvenNumbers(maxNumber);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new string[] { "abc" }, new string[] { "ABC" })]
        [InlineData(new string[] { "abc", "Def", "GHi" }, new string[] { "ABC", "DEF", "GHI" })]
        [InlineData(new string[] { "a" }, new string[] { "A" })]
        [InlineData(new string[] { "", "", "" }, new string[] { "", "", "" })]
        [InlineData(new string[] { "abc", null, "" }, new string[] { "ABC", null, "" })]
        [InlineData(new string[] { null, null, null }, new string[] { null, null, null })]
        [InlineData(null, null)]
        public void MakeElementsUppercase(string[] values, string[] expectedResult)
        {
            // Arrange
            ArraySolver arraySolver = new ArraySolver();

            // Act
            string[] actualResult = arraySolver.MakeElementsUppercase(values);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
