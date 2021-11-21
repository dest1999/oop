using System;
using Xunit;
using Fractions;

namespace FractionsTest
{
    public class UnitTest1
    {
        [Fact]
        public void CompareNotEqualsReturnFalse()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(1, 3);
            RatioNumber ratioNumber2 = new(2, 30);
            //Act
            bool result = ratioNumber1 == ratioNumber2;
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void CompareEqualsReturnTrue()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(1, 3);
            RatioNumber ratioNumber2 = new(10, 30);
            //Act
            bool result = ratioNumber1 == ratioNumber2;
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CompareLessReturnFalse()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(2, 3);
            RatioNumber ratioNumber2 = new(2, 30);
            //Act
            bool result = ratioNumber1 < ratioNumber2;
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void CompareLessReturnTrue()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(2, 30);
            RatioNumber ratioNumber2 = new(2, 3);
            //Act
            bool result = ratioNumber1 < ratioNumber2;
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CompareGreaterReturnFalse()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(1, 3);
            RatioNumber ratioNumber2 = new(2, 3);
            //Act
            bool result = ratioNumber1 > ratioNumber2;
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void CompareGreaterReturnTrue()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(2, 3);
            RatioNumber ratioNumber2 = new(1, 3);
            //Act
            bool result = ratioNumber1 > ratioNumber2;
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void TestAddition()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(2, 5);
            RatioNumber ratioNumber2 = new(1, 4);
            RatioNumber expectedResult = new(13, 20);
            //Act
            RatioNumber actionResult = ratioNumber1 + ratioNumber2;
            //Assert
            Assert.Equal(expectedResult, actionResult);
        }

        [Fact]
        public void TestSubtraction()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(2, 5);
            RatioNumber ratioNumber2 = new(1, 4);
            RatioNumber expectedResult = new(3, 20);
            //Act
            RatioNumber actionResult = ratioNumber1 - ratioNumber2;
            //Assert
            Assert.Equal(expectedResult, actionResult);
        }

        [Fact]
        public void TestDividing()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(2, 5);
            RatioNumber ratioNumber2 = new(1, 4);
            RatioNumber expectedResult = new(8, 5);
            //Act
            RatioNumber actionResult = ratioNumber1 / ratioNumber2;
            //Assert
            Assert.Equal(expectedResult, actionResult);
        }

        [Fact]
        public void TestMultipling()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(2, 5);
            RatioNumber ratioNumber2 = new(1, 4);
            RatioNumber expectedResult = new(1, 10);
            //Act
            RatioNumber actionResult = ratioNumber1 * ratioNumber2;
            //Assert
            Assert.Equal(expectedResult, actionResult);
        }

        [Fact]
        public void TestDivideReminder()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(2, 5);
            RatioNumber ratioNumber2 = new(1, 4);
            RatioNumber expectedResult = new(3, 20);
            //Act
            RatioNumber actionResult = ratioNumber1 % ratioNumber2;
            //Assert
            Assert.Equal(expectedResult, actionResult);
        }

        [Fact]
        public void TestIncrement()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(2, 5);
            RatioNumber expectedResult = new(7, 5);
            //Act
            RatioNumber actionResult = ++ratioNumber1;
            //Assert
            Assert.Equal(expectedResult, actionResult);
        }

        [Fact]
        public void TestDecrement()
        {
            //Arrange
            RatioNumber ratioNumber1 = new(7, 5);
            RatioNumber expectedResult = new(2, 5);
            //Act
            RatioNumber actionResult = --ratioNumber1;
            //Assert
            Assert.Equal(expectedResult, actionResult);
        }
    }
}
