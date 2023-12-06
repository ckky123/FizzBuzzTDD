using System;

namespace FizzBuzz.Services{
    public interface IGeneralFizzBuzzRule
    {
        bool Check(int number);
        string Print();
    }

    internal class FizzRule : IGeneralFizzBuzzRule
    {
        public bool Check(int number) => number % 3 == 0;
        public string Print() => "Fizz";
    }

    internal class BuzzRule : IGeneralFizzBuzzRule
    {
        public bool Check(int number) => number % 5 == 0;
        public string Print() => "Buzz";
    }
    
    internal class FizzBuzzRule : IGeneralFizzBuzzRule
    {
        public bool Check(int number) => number % 15 == 0;
        public string Print() => "FizzBuzz";
    }

    public class FizzBuzzService
    {
        public void Generate(){
            return;
        }

        public string GenerateSingle(int number){

            var _rules = new List<IGeneralFizzBuzzRule>
            {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule()

            };

            var rule = _rules.FirstOrDefault(r => r.Check(number));

            return rule?.Print() ?? number.ToString();
        }

    }
}