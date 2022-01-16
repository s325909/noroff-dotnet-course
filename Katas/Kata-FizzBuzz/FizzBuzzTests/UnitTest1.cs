using Kata_FizzBuzz;
using System;
using Xunit;

namespace FizzBuzzTests
{
    public class UnitTest1
    {
        [Fact]
        public void Convert_NonFizzBuzzNumber_ShouldReturnNumberAsString()
        {
            // Arrange
            FizzBuzzConverter fizzBuzz = new FizzBuzzConverter();
            int input = 1;
            String expected = "1";

            // Act
            string actucal = fizzBuzz.Convert(input);

            //Assert
            Assert.Equal(expected, actucal);
        }

        [Fact]
        public void Convert_MultipleOfThree_ShouldReturnFizz()
        {
            // Arrange
            FizzBuzzConverter fizzBuzz = new FizzBuzzConverter();
            int input = 3;
            String expected = "Fizz";

            // Act
            string actucal = fizzBuzz.Convert(input);

            //Assert
            Assert.Equal(expected, actucal);
        }

        [Fact]
        public void Convert_MultipleOfFive_ShouldReturnBuzz()
        {
            // Arrange
            FizzBuzzConverter fizzBuzz = new FizzBuzzConverter();
            int input = 5;
            String expected = "Buzz";

            // Act
            string actucal = fizzBuzz.Convert(input);

            //Assert
            Assert.Equal(expected, actucal);
        }

        [Fact]
        public void Convert_MultipleOfThreeAndFive_ShouldReturnFizzBuzz()
        {
            // Arrange
            FizzBuzzConverter fizzBuzz = new FizzBuzzConverter();
            int input = 15;
            String expected = "FizzBuzz";

            // Act
            string actucal = fizzBuzz.Convert(input);

            //Assert
            Assert.Equal(expected, actucal);
        }
    }
}
