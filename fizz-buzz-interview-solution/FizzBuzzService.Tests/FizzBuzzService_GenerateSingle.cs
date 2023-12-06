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

        [Fact]
        public void GenerateSingle_ShouldReturnFizz_WhenCalledWith3()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(3);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void GenerateSingle_ShouldReturnFizz_WhenCalledWith6()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(6);
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void GenerateSingle_ShouldReturnBuzz_WhenCalledWith5()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(5);
            Assert.Equal("Buzz", result);
        }

        [Fact]
        public void GenerateSingle_ShouldReturnBuzz_WhenCalledWith10()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(10);
            Assert.Equal("Buzz", result);
        }
    }
}