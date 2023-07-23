using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(null, null,null,0)]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 2, 3, 6)]
        [InlineData(5, 5, 10, 20)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var CalculatorTest = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = CalculatorTest.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, 0)]
        [InlineData(1, 0, 1)]//Add test data <-------
        [InlineData(10, 5, 5)]
        [InlineData(0, 0, 0)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            // create a Calculator object
            var CalculatorTest = new Calculator();

            //Act
            var actual = CalculatorTest.Sudtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, 0)]
        [InlineData(2,5,10)]//Add test data <-------
        [InlineData(3,4,12)]
        [InlineData(5,0,0)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            // create a Calculator object
            var CalculatorTest = new Calculator();

            //Act
            var actual = CalculatorTest.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(null, null, 0)]
        [InlineData(50,5,10)]//Add test data <-------
        [InlineData(1,0,0)]
        [InlineData(10,1,10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            // create a Calculator object
            var CalculatorTest = new Calculator();

            //Act
            var actual = CalculatorTest.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
