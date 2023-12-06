using FizzBuzz.Services;

namespace FizzBuzz.UnitTests.Services{
    public class FizzBuzzService_GenerateSingle
    {
        [Fact]
        public void GenerateSingle_ShouldReturnWithoutErrors()
        {
            var FizzBuzz = new FizzBuzzService();

            FizzBuzz.GenerateSingle();
        }
    }
}