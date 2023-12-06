using FizzBuzz.Services;
using Xunit;

namespace FizzBuzz.UnitTests.Services{
    public class FizzBuzzService_GenerateSingle
    {
        [Fact]
        public void GenerateSingle_ShouldReturn1_WhenCalledWith1()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(1);
            Assert.Equal("1", result);
        }

        [Fact]
        public void GenerateSingle_ShouldReturn2_WhenCalledWith2()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(2);
            Assert.Equal("2", result);
        }

        [Fact]
        public void GenerateSingle_ShouldReturnFizz_WhenCalledWith3()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(3);
            Assert.Equal("Fizz", result);
        }
    }
}