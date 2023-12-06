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
        public void Generate_ShouldReturnCorrectTwoStrings()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.Generate(1, 2);
            Assert.Equal(2, result.Count);
            Assert.Equal("1", result[0]);
            Assert.Equal("2", result[1]);
        }

        [Fact]
        public void Generate_ShouldReturnCorrectStringsForRange()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.Generate(12, 18);
            Assert.Equal("Fizz", result[0]);
            Assert.Equal("13", result[1]);
            Assert.Equal("14", result[2]);
            Assert.Equal("FizzBuzz", result[3]);
            Assert.Equal("16", result[4]);
            Assert.Equal("17", result[5]);
            Assert.Equal("Fizz", result[6]);
        }
    }
}