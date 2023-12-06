using System;
using System.Linq;

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
        private readonly List<IGeneralFizzBuzzRule> _rules;

        public FizzBuzzService(){
            _rules = new List<IGeneralFizzBuzzRule>
            {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule()
            };
        }

        public List<string> Generate(int lower, int upper){
            var values = new List<string>();
            foreach (int val in Enumerable.Range(lower, upper)){
                values.Add("");
            }
            return values;
        }

        public string GenerateSingle(int number){
            var rule = _rules.FirstOrDefault(r => r.Check(number));
            return rule?.Print() ?? number.ToString();
        }

    }
}