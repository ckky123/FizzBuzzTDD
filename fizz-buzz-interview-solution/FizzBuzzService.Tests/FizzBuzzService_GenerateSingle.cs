using FizzBuzz.Services;
using Xunit;

namespace FizzBuzz.UnitTests.Services{
    public class FizzBuzzService_GenerateSingle
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        public void GenerateSingle_ShouldReturnStringOfNumber_WhenCalledWithSimpleValue(int value, string expected)
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void GenerateSingle_ShouldReturnFizz_WhenCalledWithSimpleMultipleOf3(int value)
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(value);
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void GenerateSingle_ShouldReturnFizz_WhenCalledWithSimpleMultipleOf5(int value)
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(value);
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void GenerateSingle_ShouldReturnFizzBuzz_WhenCalledWithMultipleOf15(int value)
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(value);
            Assert.Equal("FizzBuzz", result);
        }

    }
}