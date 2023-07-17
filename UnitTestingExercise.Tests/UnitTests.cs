using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(7, 3, 40, 50)]
        [InlineData(3, 3, 3, 9)]
        [InlineData(7, 3, 1, 11)]
        [InlineData(-1, -2, -2, -5)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object - DONE
            Calculator calculator1 = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual - DONE
            var actual1 = calculator1.Add(num1, num2, num3);


            //Assert
            //Assert.Equal(expected, actual); - DONE
            Assert.Equal(expected, actual1); 
        }

        [Theory]
        [InlineData(7, 5, 2)]//Add test data <-------
        [InlineData(2, 3, -1)]
        [InlineData(17, 7, 10)]
        [InlineData(-9, -11, 2)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange - DONE
            Calculator calculator = new Calculator();

            //Act - DONE
            var actual = calculator.Subtract(minuend, subtrhend);


            //Assert - DONE
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData()]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

    }
}
