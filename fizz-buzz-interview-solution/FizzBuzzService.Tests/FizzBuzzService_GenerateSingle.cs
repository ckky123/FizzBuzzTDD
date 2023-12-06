using FizzBuzz.Services;

namespace FizzBuzz.UnitTests.Services{
    public class FizzBuzzService_GenerateSingle
    {
        [Fact]
        public void GenerateSingle_ShouldReturnStringWithoutErrors()
        {
            var FizzBuzz = new FizzBuzzService();

            var result = FizzBuzz.GenerateSingle(1);
        }
    }
}