using FizzBuzz.Services;
using Xunit;

namespace FizzBuzz.UnitTests.Services{
    public class FizzBuzzService_GenerateSingle
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(4, "4")]
        [InlineData(14, "14")]
        [InlineData(97, "97")]
        [InlineData(-1, "-1")]
        [InlineData(-52, "-52")]
        public void GenerateSingle_ShouldReturnStringOfNumber_WhenCalledWithSimpleValue(int value, string expected)
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(99)]
        [InlineData(-3)]
        [InlineData(-18)]
        public void GenerateSingle_ShouldReturnFizz_WhenCalledWithSimpleMultipleOf3(int value)
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(value);
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(100)]
        [InlineData(-10)]
        [InlineData(-100)]
        public void GenerateSingle_ShouldReturnFizz_WhenCalledWithSimpleMultipleOf5(int value)
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(value);
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(90)]
        [InlineData(-15)]
        [InlineData(-150)]
        public void GenerateSingle_ShouldReturnFizzBuzz_WhenCalledWithMultipleOf15(int value)
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(value);
            Assert.Equal("FizzBuzz", result);
        }

    }
}