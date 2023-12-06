using FizzBuzz.Services;

namespace FizzBuzz.UnitTests.Services{
    public class FizzBuzzService_Generate
    {
        [Fact]
        public void Generate_ShouldReturnSingleString()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.Generate(1, 1);
            Assert.Equal(1, result.Count);
        }

        [Fact]
        public void Generate_ShouldReturnTwoStrings()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.Generate(1, 2);
            Assert.Equal(2, result.Count);
        }
    }
}