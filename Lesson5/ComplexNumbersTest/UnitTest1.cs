using System;
using Xunit;
using ComplexNumbers;

namespace ComplexNumbersTest
{
    public class UnitTest1
    {
        [Fact]
        public void CompareEqualsReturnTrue()
        {
            ComplexNumber complexNumber1 = new ComplexNumber(3, 3);
            ComplexNumber complexNumber2 = new ComplexNumber(3, 3);

            Assert.True(complexNumber1.Equals(complexNumber2));
        }

        [Fact]
        public void AnotherCompareEqualsReturnTrue()
        {
            ComplexNumber complexNumber1 = new ComplexNumber(3, 3);
            ComplexNumber complexNumber2 = new ComplexNumber(3, 3);

            Assert.True(complexNumber1 == complexNumber2);
        }

        [Fact]
        public void CompareNotEqualsReturnFalse()
        {
            ComplexNumber complexNumber1 = new ComplexNumber(3, 3);
            ComplexNumber complexNumber2 = new ComplexNumber(3, -3);

            Assert.False(complexNumber1 == complexNumber2);
        }

        [Fact]
        public void TestAddition()
        {
            ComplexNumber complexNumber1 = new ComplexNumber(2, 3);
            ComplexNumber complexNumber2 = new ComplexNumber(1, -2);
            ComplexNumber expectedResult = new ComplexNumber(3, 1);

            ComplexNumber actionResult = complexNumber1 + complexNumber2;

            Assert.Equal(expectedResult, actionResult);
        }

        [Fact]
        public void TestSubtraction()
        {
            ComplexNumber complexNumber1 = new ComplexNumber(2, 3);
            ComplexNumber complexNumber2 = new ComplexNumber(1, -2);
            ComplexNumber expectedResult = new ComplexNumber(1, 5);

            ComplexNumber actionResult = complexNumber1 - complexNumber2;

            Assert.Equal(expectedResult, actionResult);
        }

        [Fact]
        public void TestMultipling()
        {
            ComplexNumber complexNumber1 = new ComplexNumber(2, 3);
            ComplexNumber complexNumber2 = new ComplexNumber(1, -2);
            ComplexNumber expectedResult = new ComplexNumber(8, -1);

            ComplexNumber actionResult = complexNumber1 * complexNumber2;

            Assert.Equal(expectedResult, actionResult);
        }

    }
}
