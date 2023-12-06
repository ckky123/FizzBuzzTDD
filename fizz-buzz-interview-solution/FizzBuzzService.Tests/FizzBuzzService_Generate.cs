using FizzBuzz.Services;

namespace FizzBuzz.UnitTests.Services{
    public class FizzBuzzService_Generate
    {
        [Fact]
        public void Generate_ShouldReturnWithoutErrors()
        {
            var FizzBuzz = new FizzBuzzService();

            FizzBuzz.Generate();
        }
    }
}