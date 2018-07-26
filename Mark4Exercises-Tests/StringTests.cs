using System;
using Xunit;
using Mark4Exercises;

namespace Mark4Exercises_Tests
{
    public class StringTests
    {
        [Theory]
        [InlineData("First", "Last", "First Last")]
        [InlineData("Charlie", "Brown", "Charlie Brown")]
        [InlineData("Charlie", "", "Charlie")]
        [InlineData("", "Brown", "Brown")]
        [InlineData("", "", "")]
        [InlineData("Charlie", null, "Charlie")]
        [InlineData(null, "Brown", "Brown")]
        [InlineData(null, null, "")]
        public void FullName(string firstName, string lastName, string expectedResult)
        {
            // Arrange
            StringSolver stringSolver = new StringSolver();

            // Act
            string actualResult = stringSolver.FullName(firstName, lastName);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("abc", "ABC")]
        [InlineData("Abc", "ABC")]
        [InlineData("ABC", "ABC")]
        [InlineData("abc123", "ABC123")]
        [InlineData("", "")]
        [InlineData(null, "")]
        public void MakeUppercase(string value, string expectedResult)
        {
            // Arrange
            StringSolver stringSolver = new StringSolver();

            // Act
            string actualResult = stringSolver.MakeUppercase(value);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("abc", "ABC", false)]
        [InlineData("Abc", "ABC", false)]
        [InlineData("ABC", "ABC", true)]
        [InlineData("ABC", "DEF", false)]
        [InlineData("abc123", "ABC123", false)]
        [InlineData("ABC123", "ABC123", true)]
        [InlineData("", "", true)]
        [InlineData(null, "", false)]
        [InlineData(null, null, false)]
        public void AreEqual(string value1, string value2, bool expectedResult)
        {
            // Arrange
            StringSolver stringSolver = new StringSolver();

            // Act
            bool actualResult = stringSolver.AreEqual(value1, value2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData("abc", "ABC", true)]
        [InlineData("Abc", "ABC", true)]
        [InlineData("ABC", "ABC", true)]
        [InlineData("ABC", "DEF", false)]
        [InlineData("abc123", "ABC123", true)]
        [InlineData("ABC123", "ABC123", true)]
        [InlineData("", "", true)]
        [InlineData(null, "", false)]
        [InlineData(null, null, false)]
        public void AreEqualIgnoreCase(string value1, string value2, bool expectedResult)
        {
            // Arrange
            StringSolver stringSolver = new StringSolver();

            // Act
            bool actualResult = stringSolver.AreEqualIgnoreCase(value1, value2);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
