using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(6, 8, 10, 24)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var add = new UnitTestMethods();
            //Act
            var actual = add.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(55, 8, 47)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var subtract = new UnitTestMethods();
            //Act
            var actual = subtract.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20, 5, 100)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var multiply = new UnitTestMethods();
            //Act
            var actual = multiply.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(68, 4, 17)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var divide = new UnitTestMethods();
            //Act
            var actual = divide.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var test1 = new UnitTestMethods();
            //Act
            string actual = test1.Alphabet();
            //Assert
            Assert.Equal("abcdefghijklmnopqrstuvwxyz", actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var test2 = new UnitTestMethods();
            //Act
            string actual = test2.Message();
            //Assert
            Assert.Equal("Hey! Please give me a call when you get the chance", actual);
        }
    }
}
