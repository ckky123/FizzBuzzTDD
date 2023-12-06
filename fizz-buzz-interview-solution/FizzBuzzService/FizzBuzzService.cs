using System;
using System.Linq;

namespace FizzBuzz.Services{
    public interface IGeneralFizzBuzzRule
    {
        bool Check(int number);
        string Print();
    }

    public interface IOutputService
    {
        void Print(string output);
    }

    public class ConsoleOutputService : IOutputService
    {
        public void Print(string output)
        {
            Console.WriteLine(output);
        }
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
        private readonly IOutputService _outputService;

        public FizzBuzzService(){
            _rules = new List<IGeneralFizzBuzzRule>
            {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule()
            };

            _outputService = new ConsoleOutputService(); 
        }

        public List<string> Generate(int lower, int upper){
            var stringValues = new List<string>();
            foreach (int val in Enumerable.Range(lower, upper)){
                stringValues.Add(GenerateSingle(val));
            }

            foreach(var singleValue in stringValues){
                _outputService.Print(singleValue); // Output to the console
            }

            return stringValues;
        }

        public string GenerateSingle(int number){
            var rule = _rules.FirstOrDefault(r => r.Check(number));
            return rule?.Print() ?? number.ToString();
        }

    }
}