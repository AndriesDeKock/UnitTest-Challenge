using CalculationsLibrary;
using System;
using Xunit;

namespace CalculationsLibraryTest
{
    public class CalculatorLibraryTest
    {
        [Theory]
        [InlineData(5, 1, 6)]
        [InlineData(50, 50, 100)]
        [InlineData(-5, 1, -4)]
        [InlineData(1.75, 2.85, 4.6)]
        [InlineData(double.MaxValue, double.MaxValue, double.MaxValue * 2)]
        private void Calculator_Add_Calculate(double x, double y, double expected)
        {
            // Act
            double actual = Calculator.Add(x, y);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(100, 50, 2)]
        [InlineData(1, 2, 0.5)]
        private void Calculator_Divide_Calculate(double x, double y, double expected)
        {

            // Act
            double actual = Calculator.Divide(x, y);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        private void Calculator_Divide_ThrowsArgumentExpection()
        {
            // Arrange
            double x = 5;
            double y = 0;

            // Assert
            Assert.Throws<ArgumentException>(() => { Calculator.Divide(x, y); });
        }

        [Theory]
        [InlineData(5, 10, 1, 20, 15)]
        [InlineData(10, 10, 10, 10, 20)]
        private void Calculator_LimitedAdd_Calculate(double x, double y, double minValue, double maxValue, double expected)
        {

            // Act
            double actual = Calculator.LimitedAdd(x, y, minValue, maxValue);

            // Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5, 20, 9, 1)]
        [InlineData(10, 30, 5, 15)]
        private void Calculator_LimitedAdd_X_ThrowsArgumentOutOfRangeException(double x, double y, double minValue, double maxValue)
        {

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {

                Calculator.LimitedAdd(x, y, minValue, maxValue);

            });

        }

        [Theory]
        [InlineData(5, 20, 30, 10)]
        [InlineData(10, 30, 15, 50)]
        private void Calculator_LimitedAdd_Y_ThrowsArgumentOutOfRangeException(double x, double y, double minValue, double maxValue)
        {


            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {

                Calculator.LimitedAdd(x, y, minValue, maxValue);

            });

        }

    }
}
