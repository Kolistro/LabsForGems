using MyUnit;
using MyUnit.Attributes;

namespace SystemArithmetic.Tests
{
    public class ArithmeticTest
    {
        [MyFact]
        public void OnePlusOne_EqualsTwo()
        {
            // Arrange.
            const int a = 1;
            const int b = 1;
            const int expected = 2;

            // Act.
            const int result = a + b;

            // Assert.
            MyAssert.Equal(expected, result);
        }

        [MyFact]
        public void TwoTimesTwo_EqualsFour()
        {
            // Arrange.
            const int a = 2;
            const int b = 2;
            const int expected = 4;

            // Act.
            const int result = a * b;

            // Assert.
            MyAssert.Equal(expected, result);
        }

        [MyFact]
        public void FourByTwo_EqualsTwo()
        {
            // Arrange.
            const int a = 4;
            const int b = 2;
            const int expected = 2;

            // Act.
            const int result = a / b;

            // Assert.
            MyAssert.Equal(expected, result);
        }

        [MyFact]
        public void DivideByZero_Throws()
        {
            // Arrange.
            int a = 4;
            int b = 0;

            // Assert + Act.
            MyAssert.Throws<DivideByZeroException>(() => a / b);
        }

        [MyTheory]
        [MyInlineData(1, 1, 1, 1)]
        [MyInlineData(2, 4, 1, 8)]
        [MyInlineData(5, 5, 5, 125)]
        public void MultiplicationOfThreeNumbers(int a, int b, int c, int expected)
        {
            // Act.
            int result = a * b * c;

            // Assert.
            MyAssert.Equal(expected, result);
        }
    }
}
